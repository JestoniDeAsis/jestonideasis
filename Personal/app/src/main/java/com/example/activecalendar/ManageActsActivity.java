package com.example.activecalendar;

import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.RadioButton;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class ManageActsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_manage_acts);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        String[] sampleActivities = {
                "Easy run",
                "Tempo run",
                "Long run"
        };

        int[] sampleColors = {
                Color.RED,
                Color.BLUE,
                Color.YELLOW
        };

        LinearLayout layoutActivities = findViewById(R.id.layoutActivities);

        ArrayList<RadioButton> radioButtons = new ArrayList<>();

        // ===== Saved Activities =====
        for (int i = 0; i < sampleActivities.length; i++) {

            String activity = sampleActivities[i];
            int color = sampleColors[i];

            LinearLayout activityContainer = new LinearLayout(this);
            activityContainer.setOrientation(LinearLayout.HORIZONTAL);
            activityContainer.setGravity(Gravity.CENTER_VERTICAL);
            activityContainer.setPadding(0, 0, 0, 10);

            RadioButton radioButton = new RadioButton(this);

            LinearLayout.LayoutParams radioParams =
                    new LinearLayout.LayoutParams(
                            0,
                            LinearLayout.LayoutParams.WRAP_CONTENT,
                            1f
                    );

            radioButton.setLayoutParams(radioParams);
            radioButton.setText(activity);
            radioButton.setTextSize(17);

            radioButtons.add(radioButton);

            radioButton.setOnClickListener(view -> {
                for (RadioButton rb : radioButtons) {
                    rb.setChecked(false);
                }
                radioButton.setChecked(true);
            });

            // Color Display
            View colorSquare = new View(this);

            LinearLayout.LayoutParams colorParams =
                    new LinearLayout.LayoutParams(65, 65);

            colorSquare.setLayoutParams(colorParams);

            GradientDrawable drawable = new GradientDrawable();
            drawable.setShape(GradientDrawable.RECTANGLE);

            drawable.setCornerRadius(12f);

            drawable.setColor(color);

            colorSquare.setBackground(drawable);

            activityContainer.addView(radioButton);
            activityContainer.addView(colorSquare);

            layoutActivities.addView(activityContainer);
        }

        // ===== Extra invisible scroll space =====
        View spacer = new View(this);

        LinearLayout.LayoutParams spacerParams =
                new LinearLayout.LayoutParams(
                        LinearLayout.LayoutParams.MATCH_PARENT,
                        300 // height in px (increase/decrease as needed)
                );

        spacer.setLayoutParams(spacerParams);
        spacer.setVisibility(View.INVISIBLE);

        layoutActivities.addView(spacer);
    }
}