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

                LinearLayout.LayoutParams radioParams =
                        new LinearLayout.LayoutParams(
                                0,
                                LinearLayout.LayoutParams.WRAP_CONTENT,
                                1f
                        );

                radioButton.setLayoutParams(radioParams);
                radioButton.setText(activity);

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

                // Color Circle
                View colorCircle = new View(this);

                LinearLayout.LayoutParams colorParams =
                        new LinearLayout.LayoutParams(40, 40);

                colorCircle.setLayoutParams(colorParams);

                GradientDrawable drawable = new GradientDrawable();
                drawable.setShape(GradientDrawable.OVAL);
                drawable.setColor(color);

                colorCircle.setBackground(drawable);

                // Add to row
                activityContainer.addView(radioButton);
                activityContainer.addView(colorCircle);

                // Add row to layout
                layoutActivities.addView(activityContainer);
            }

            builder.setView(dialogView)
                    .setPositiveButton("Select", (dialog, which) -> {

                        for (RadioButton rb : radioButtons) {
                            if (rb.isChecked()) {
                                btn_chooseActivity.setText(rb.getText().toString());
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

//        spinner_activities.setAdapter(adapter);
//
//        spinner_activities.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
//            @Override
//            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
//                if (spinner_activities.getSelectedItemId() == 0) {
//                    textInputLayout_activityName.setEnabled(true);
//                    editText_activityName.setText("");
//                }
//                else {
//                    textInputLayout_activityName.setEnabled(false);
//                    editText_activityName.setText(spinner_activities.getSelectedItem().toString());
//                }
//            }
//
//            @Override
//            public void onNothingSelected(AdapterView<?> parent) {
//
//            }
//        });
    }
}