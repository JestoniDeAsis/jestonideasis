package com.example.activecalendar;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Spinner;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.google.android.material.textfield.TextInputEditText;
import com.google.android.material.textfield.TextInputLayout;


public class AddActivity extends AppCompatActivity {
    TextInputLayout textInputLayout_activityName;
    TextInputEditText editText_activityName;
    Spinner spinner_activities;

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
        spinner_activities = findViewById(R.id.spinner_activities);

        String[] sampleActivities = {
                "Others",
                "Easy run",
                "Tempo run",
                "Long run"
        };

        ArrayAdapter<String> adapter = new ArrayAdapter<>(
                this,
                android.R.layout.simple_spinner_item,
                sampleActivities
        );

        adapter.setDropDownViewResource(
                android.R.layout.simple_spinner_dropdown_item
        );

        spinner_activities.setAdapter(adapter);

        spinner_activities.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                if (spinner_activities.getSelectedItemId() == 0) {
                    textInputLayout_activityName.setEnabled(true);
                    editText_activityName.setText("");
                }
                else {
                    textInputLayout_activityName.setEnabled(false);
                    editText_activityName.setText(spinner_activities.getSelectedItem().toString());
                }
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });
    }
}