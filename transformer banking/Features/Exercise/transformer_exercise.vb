Module transformer_exercise
    Public Class exercises
        Dim query As String
        Public Function exercise_questions(no)
            Dim question As String = ""
            If no = 1 Then
                question = "This is the commonly used three-phase transformer connection.  It is common in commercial, industrial, and high-density residential locations, to supply three-phase distribution systems.  The primary winding allows third-harmonic currents to circulate within the transformer and prevents third-harmonic currents from flowing in the supply line."
            ElseIf no = 2 Then
                question = "Three single-phase transformers each rated 75 kVA are banked in delta and supplying a three-phase load drawing 160 kVA at 0.8 lagging power factor. If one transformer is removed for repairs, solve for the amount of overloading of the remaining units."
            ElseIf no = 3 Then
                question = "It is the type of transformer banking connection that is most often used to step down relatively high transmission line voltages (60,900 volts or more) at the consumer’s location. Two reasons for selecting this type of transformer bank are that the three-phase voltage is decreased by the transformer ratio multiplied by the factor 1.73 also known as √3, and the insulation requirements for the high-voltage primary windings are reduced."
            ElseIf no = 4 Then
                question = "A three-phase 150 kVA, 4160 V, 0.8 lagging pf load is to be supplied by three single-phase transformers having a turns ratio of 2. Calculate the current that flows in the primary windings if the transformers supply a Circuit Breaker Manufacturer to reduce impact of SLG faults on the primary system."
            ElseIf no = 5 Then
                question = "In this connection, without the primary neutral connection, serious unbalances in the line-neutral voltage may result from unequal exciting admittances among the three transformers and unbalanced line-to-neutral loads in the secondary. Also, if the third harmonics are suppressed in the exciting current, large third harmonic components may appear in the line-to-neutral voltages. This connection is a four-wire system if balanced voltages are to be assured."
            ElseIf no = 6 Then
                question = "A three-phase transformer bank is used to supply Gourmet Food Manufacturing Inc. The primary to secondary voltage ratio is 4160/120. Solve for the primary line current if the secondary load draws a line current of 1000 A."
            ElseIf no = 7 Then
                question = "Due to the absence of neutral point, it is not suitable for three phase four wire system. More insulation is required and the voltage appearing between windings and core will be equal to full line voltage in case of earth fault on one phase."
            ElseIf no = 8 Then
                question = "A bank of three 50:1 single-phase transformers supply a facility with motor starter timers since large amounts of ampere are needed at the start of the process. It is used to step down the HV transmission line rated 138 kV. Determine the magnitude of the step-down voltage."
            ElseIf no = 9 Then
                question = "This type of transformer connection is quite often used in electrical power distribution systems where the load is expected to grow. When the load does grow, a third transformer may be added. It consists of two single-phase transformers. One of them is a conventional single-phase two-winding transformer and the other is a single-phase three wire transformer."
            ElseIf no = 10 Then
                question = "A distribution transformer rated 50 kVA, 4160 V/120 V is connected in a four-wire system. This connection requires a neutral connection between the source and the primary of the transformers to assure balanced line-to-neutral voltage and to provide a path for the third-harmonic component in the exciting current of the transformers. What are the line currents at full load?"
            ElseIf no = 11 Then
                question = "BatLight Corporation, a distribution utility, supplies two single-phase transformers banked in delta. If each transformer is rated 75 kVA capacity, what is the maximum three-phase load in kilowatts that the bank can carry without suffering overload considering that the load has a lagging power factor of 0.80?"
            ElseIf no = 12 Then
                question = "A three-phase transformation of energy is possible using only two transformers. The __________ transformer banks are widely used in rural or suburban areas where the load densities are low, but where both single and three-phase services are required. "
            End If
            Return question
        End Function
        Public Function exercise_answer(no)
            Dim connection As String = ""
            If no = 1 Then
                connection = "delta-wye"
            ElseIf no = 2 Then
                connection = "open-delta"
            ElseIf no = 3 Then
                connection = "wye-delta"
            ElseIf no = 4 Then
                connection = "delta-delta"
            ElseIf no = 5 Then
                connection = "wye-wye"
            ElseIf no = 6 Then
                connection = "delta-wye"
            ElseIf no = 7 Then
                connection = "delta-delta"
            ElseIf no = 8 Then
                connection = "wye-delta"
            ElseIf no = 9 Then
                connection = "openwye-opendelta"
            ElseIf no = 10 Then
                connection = "wye-wye"
            ElseIf no = 11 Then
                connection = "open-delta"
            ElseIf no = 12 Then
                connection = "openwye-opendelta"
            End If
            Return connection
        End Function

        Public Function get_exercise_no()
            query = "select b.* from exercise_transformer_details as a
	                 left join results_exercises as b
	                 on a.id = b.transformer_id::integer
                    where transformer_id is not null and 
	                primary_phase_current is not null and 
	                primary_line_current is not null and 
	                primary_line_voltage is not null and 
	                primary_phase_voltage is not null and 
	                apparent_power is not null and 
	                real_power is not null and 
	                secondary_phase_current is not null and 
	                secondary_line_current is not null and 
	                secondary_line_voltage is not null and
	                secondary_phase_voltage is not null "
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            Return dt.Rows.Count + 1


        End Function
    End Class
End Module
