package com.example.activecalendar;

import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.Button;
import android.widget.GridLayout;
import android.widget.LinearLayout;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Locale;


public class MainActivity extends AppCompatActivity {
    TextView txtV_monthName;
    GridLayout gridL_daysContainer;
    Button btn_prevMonth, btn_nextMonth;

    int yearToView = 2026;
    int monthToView = 5;
    int currentDay, currentMonth, currentYear;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        txtV_monthName = findViewById(R.id.txtV_monthName);
        gridL_daysContainer = findViewById(R.id.gridL_daysContainer);
        btn_prevMonth = findViewById(R.id.btn_prevMonth);
        btn_nextMonth = findViewById(R.id.btn_nextMonth);


        Calendar calendar = Calendar.getInstance();

        currentYear = calendar.get(Calendar.YEAR);
        currentMonth = calendar.get(Calendar.MONTH) + 1;
        currentDay = calendar.get(Calendar.DAY_OF_MONTH);

        yearToView = currentYear;
        monthToView = currentMonth;

        setCalendarDisplay(monthToView, yearToView);

        btn_prevMonth.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                monthToView -= 1;
                if (monthToView == -1) {
                    monthToView = 11;
                    yearToView -= 1;
                }
                else if (monthToView == 12) {
                    monthToView = 0;
                    yearToView += 1;
                }
                setCalendarDisplay(monthToView, yearToView);
            }
        });

        btn_nextMonth.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                monthToView += 1;
                setCalendarDisplay(monthToView, yearToView);
            }
        });

        }

    void setCalendarDisplay(int month, int year) {

        gridL_daysContainer.removeAllViews();

        Calendar calendar = Calendar.getInstance();

        calendar.set(year, month, 1);

        SimpleDateFormat monthFormat =
                new SimpleDateFormat("MMMM yyyy", Locale.getDefault());

        txtV_monthName.setText(monthFormat.format(calendar.getTime()));

        int firstDayOfWeek = calendar.get(Calendar.DAY_OF_WEEK);
        int daysInMonth = calendar.getActualMaximum(Calendar.DAY_OF_MONTH);

        int offset = firstDayOfWeek - Calendar.MONDAY;

        if (offset < 0) {
            offset += 7;
        }

        Calendar previousMonth = (Calendar) calendar.clone();
        previousMonth.add(Calendar.MONTH, -1);

        int daysInPreviousMonth =
                previousMonth.getActualMaximum(Calendar.DAY_OF_MONTH);

        int firstPreviousDay =
                daysInPreviousMonth - offset + 1;

        int totalCells = 42;
        int usedCells = offset + daysInMonth;
        int nextMonthDays = totalCells - usedCells;

        // Previous month's trailing days
        for (int day = firstPreviousDay; day <= daysInPreviousMonth; day++) {

            LinearLayout dayContainer = new LinearLayout(this);

            dayContainer.setGravity(Gravity.TOP | Gravity.CENTER_HORIZONTAL);
            dayContainer.setPadding(0, 5, 0, 0);
            dayContainer.setBackgroundResource(R.drawable.cell_border);

            GradientDrawable drawable = (GradientDrawable) dayContainer.getBackground();
            drawable.setStroke(1, Color.argb(128, 0, 0, 0));

            TextView dayText = new TextView(this);

            dayText.setText(String.valueOf(day));
            dayText.setPadding(20, 0, 20, 0);
            dayText.setAlpha(0.8f);

            dayContainer.addView(dayText);


            GridLayout.LayoutParams dayContainerParams = new GridLayout.LayoutParams();

            dayContainerParams.width = 0;
            dayContainerParams.height = 0;
            dayContainerParams.columnSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);
            dayContainerParams.rowSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);

            dayContainer.setLayoutParams(dayContainerParams);

            gridL_daysContainer.addView(dayContainer);
        }

        // Current month day cells
        for (int day = 1; day <= daysInMonth; day++) {

            LinearLayout dayContainer = new LinearLayout(this);

            dayContainer.setGravity(Gravity.TOP | Gravity.CENTER_HORIZONTAL);
            dayContainer.setPadding(0, 5, 0, 0);
            dayContainer.setBackgroundResource(R.drawable.cell_border);

            TextView dayText = new TextView(this);

            dayText.setText(String.valueOf(day));
            dayText.setPadding(20, 0, 20, 0);
//            dayText.setTypeface(dayText.getTypeface(), Typeface.BOLD);
            if (currentMonth == monthToView && currentYear == yearToView && day == currentDay) {
                GradientDrawable drawable = (GradientDrawable) dayContainer.getBackground().mutate();
                drawable.setStroke(3, Color.argb(255, 0, 0, 0));

                GradientDrawable bg = new GradientDrawable();
                bg.setColor(Color.argb(128, 255, 0, 0));
                bg.setCornerRadius(10);

                dayText.setBackground(bg);
            }

            dayContainer.addView(dayText);


            GridLayout.LayoutParams dayContainerParams = new GridLayout.LayoutParams();

            dayContainerParams.width = 0;
            dayContainerParams.height = 0;
            dayContainerParams.columnSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);
            dayContainerParams.rowSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);

            dayContainer.setLayoutParams(dayContainerParams);

            gridL_daysContainer.addView(dayContainer);
        }

        // Next month's leading days
        for (int day = 1; day <= nextMonthDays; day++) {

            LinearLayout dayContainer = new LinearLayout(this);

            dayContainer.setGravity(Gravity.TOP | Gravity.CENTER_HORIZONTAL);
            dayContainer.setBackgroundResource(R.drawable.cell_border);
            dayContainer.setPadding(0, 5, 0, 0);

            TextView dayText = new TextView(this);

            dayText.setText(String.valueOf(day));
            dayText.setPadding(20, 0, 20, 0);
            dayText.setAlpha(0.8f);

            dayContainer.addView(dayText);


            GridLayout.LayoutParams dayContainerParams = new GridLayout.LayoutParams();

            dayContainerParams.width = 0;
            dayContainerParams.height = 0;
            dayContainerParams.columnSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);
            dayContainerParams.rowSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);

            dayContainer.setLayoutParams(dayContainerParams);

            gridL_daysContainer.addView(dayContainer);
        }
    }
}