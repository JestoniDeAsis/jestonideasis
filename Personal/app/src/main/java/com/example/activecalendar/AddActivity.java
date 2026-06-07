package com.example.activecalendar;

import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.Gravity;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.LinearLayout;
import android.widget.RadioButton;
import android.widget.RadioGroup;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;

import java.util.ArrayList;


public class AddActivity extends AppCompatActivity {
    TextInputLayout textInputLayout_activityName;
    TextInputEditText editText_activityName;
    Button btn_chooseActivity;
    View view_activityColor;
//    Spinner spinner_activities;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_add);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        textInputLayout_activityName = findViewById(R.id.textInputLayout_activityName);
        editText_activityName = findViewById(R.id.editText_activityName);
        btn_chooseActivity = findViewById(R.id.btn_chooseActivity);
        view_activityColor = findViewById(R.id.view_activityColor);
//        spinner_activities = findViewById(R.id.spinner_activities);

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

        btn_chooseActivity.setOnClickListener(v -> {

            AlertDialog.Builder builder = new AlertDialog.Builder(this);

            View dialogView = getLayoutInflater()
                    .inflate(R.layout.dialog_activity_options, null);

            LinearLayout layoutActivities =
                    dialogView.findViewById(R.id.layoutActivities);

            ArrayList<RadioButton> radioButtons = new ArrayList<>();

            // ===== Others =====

            RadioButton othersRadioButton = new RadioButton(this);
            othersRadioButton.setText("Others");
            othersRadioButton.setTextSize(15);

            if (btn_chooseActivity.getText().toString().equals("Others")) {
                othersRadioButton.setChecked(true);
            }

            radioButtons.add(othersRadioButton);

            othersRadioButton.setOnClickListener(view -> {
                for (RadioButton rb : radioButtons) {
                    rb.setChecked(false);
                }

                othersRadioButton.setChecked(true);
            });

            layoutActivities.addView(othersRadioButton);

            // ===== Saved Activities =====

            for (int i = 0; i < sampleActivities.length; i++) {

                String activity = sampleActivities[i];
                int color = sampleColors[i];

                LinearLayout activityContainer = new LinearLayout(this);
                activityContainer.setOrientation(LinearLayout.HORIZONTAL);
                activityContainer.setGravity(Gravity.CENTER_VERTICAL);

                // Radio Button
                RadioButton radioButton = new RadioButton(this);
                radioButton.setTag(color);

                LinearLayout.LayoutParams radioParams =
                        new LinearLayout.LayoutParams(
                                0,
                                LinearLayout.LayoutParams.WRAP_CONTENT,
                                1f
                        );

                radioButton.setLayoutParams(radioParams);
                radioButton.setText(activity);
                radioButton.setTextSize(15);
                radioButton.setTag(color);

                if (btn_chooseActivity.getText().toString().equals(activity)) {
                    radioButton.setChecked(true);
                }

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
                        new LinearLayout.LayoutParams(60, 60);
                colorParams.setMarginEnd(50);

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

            builder.setView(dialogView)
                    .setPositiveButton("Select", (dialog, which) -> {

                        for (RadioButton rb : radioButtons) {
                            if (rb.isChecked()) {

                                String selectedActivity = rb.getText().toString();
                                btn_chooseActivity.setText(selectedActivity);

                                int selectedColor;

                                if (selectedActivity.equals("Others")) {
                                    selectedColor = Color.BLACK;

                                    editText_activityName.setText("");
                                    textInputLayout_activityName.setEnabled(true);
                                } else {
                                    selectedColor = (int) rb.getTag();

                                    editText_activityName.setText(selectedActivity);
                                    textInputLayout_activityName.setEnabled(false);
                                }

                                GradientDrawable bg =
                                        (GradientDrawable) view_activityColor.getBackground();

                                bg.setColor(selectedColor);

                                break;
                            }
                        }

                    })
                    .setNegativeButton("Cancel", null)
                    .setNeutralButton("Manage", (dialog, which) -> {

                        Intent intent = new Intent(this, ManageActsActivity.class);
                        startActivity(intent);

                    })
                    .show();
        });
    }
}