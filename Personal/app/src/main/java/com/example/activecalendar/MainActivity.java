package com.example.activecalendar;

import android.os.Bundle;
import android.view.Gravity;
import android.widget.GridLayout;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Locale;


public class MainActivity extends AppCompatActivity {
    TextView txtV_monthName;
    GridLayout gridL_daysContainer;

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

        setCalendarDisplay(5, 2026);
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
        for (int day = firstPreviousDay;
             day <= daysInPreviousMonth;
             day++) {

            TextView tv = new TextView(this);

            tv.setText(String.valueOf(day));
            tv.setGravity(Gravity.TOP | Gravity.CENTER_HORIZONTAL);
            tv.setBackgroundResource(R.drawable.cell_border);
            tv.setAlpha(0.4f);

            GridLayout.LayoutParams params =
                    new GridLayout.LayoutParams();

            params.width = 0;
            params.height = 0;
            params.columnSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);
            params.rowSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);

            tv.setLayoutParams(params);

            gridL_daysContainer.addView(tv);
        }

        // Current month day cells
        for (int day = 1; day <= daysInMonth; day++) {

            TextView tv = new TextView(this);

            tv.setText(String.valueOf(day));
            tv.setGravity(Gravity.TOP | Gravity.CENTER_HORIZONTAL);
            tv.setBackgroundResource(R.drawable.cell_border);

            GridLayout.LayoutParams params =
                    new GridLayout.LayoutParams();

            params.width = 0;
            params.height = 0;
            params.columnSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);
            params.rowSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);

            tv.setLayoutParams(params);

            gridL_daysContainer.addView(tv);
        }

        // Next month's leading days
        for (int day = 1; day <= nextMonthDays; day++) {

            TextView tv = new TextView(this);

            tv.setText(String.valueOf(day));
            tv.setGravity(Gravity.TOP | Gravity.CENTER_HORIZONTAL);
            tv.setBackgroundResource(R.drawable.cell_border);
            tv.setAlpha(0.4f);

            GridLayout.LayoutParams params =
                    new GridLayout.LayoutParams();

            params.width = 0;
            params.height = 0;
            params.columnSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);
            params.rowSpec = GridLayout.spec(GridLayout.UNDEFINED, 1f);

            tv.setLayoutParams(params);

            gridL_daysContainer.addView(tv);
        }
    }
}