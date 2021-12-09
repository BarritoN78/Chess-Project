Option Explicit On
Option Strict On
Option Infer Off
' Barry Norton
' CPT-206
' Final Project
Imports System.ComponentModel

Public Class frmMain
    Dim str_Pics() As String = {"Photos\Unoccupied_WT.png", "Photos\Unoccupied_BT.png", "Photos\Unoccupied_ST.png", 'Unoccupied files Index 0 - 2
            "Photos\W_Pawn_WT.png", "Photos\W_Pawn_BT.png", "Photos\B_Pawn_WT.png", "Photos\B_Pawn_BT.png", "Photos\W_Pawn_ST.png", "Photos\W_Pawn_KT.png", "Photos\B_Pawn_ST.png", "Photos\B_Pawn_KT.png", 'Pawn files Index 3 - 10
            "Photos\W_Rook_WT.png", "Photos\W_Rook_BT.png", "Photos\B_Rook_WT.png", "Photos\B_Rook_BT.png", "Photos\W_Rook_ST.png", "Photos\W_Rook_KT.png", "Photos\B_Rook_ST.png", "Photos\B_Rook_KT.png", 'Rook files Index 11 - 18
            "Photos\W_Knight_WT.png", "Photos\W_Knight_BT.png", "Photos\B_Knight_WT.png", "Photos\B_Knight_BT.png", "Photos\W_Knight_ST.png", "Photos\W_Knight_KT.png", "Photos\B_Knight_ST.png", "Photos\B_Knight_KT.png", 'Knight files Index 19 - 26
            "Photos\W_Bishop_WT.png", "Photos\W_Bishop_BT.png", "Photos\B_Bishop_WT.png", "Photos\B_Bishop_BT.png", "Photos\W_Bishop_ST.png", "Photos\W_Bishop_KT.png", "Photos\B_Bishop_ST.png", "Photos\B_Bishop_KT.png", 'Bishop files  Index 27 - 34
            "Photos\W_Queen_WT.png", "Photos\W_Queen_BT.png", "Photos\B_Queen_WT.png", "Photos\B_Queen_BT.png", "Photos\W_Queen_ST.png", "Photos\W_Queen_KT.png", "Photos\B_Queen_ST.png", "Photos\B_Queen_KT.png", 'Queen files Index 35 - 42
            "Photos\W_King_WT.png", "Photos\W_King_BT.png", "Photos\B_King_WT.png", "Photos\B_King_BT.png", "Photos\W_King_ST.png", "Photos\W_King_KT.png", "Photos\B_King_ST.png", "Photos\B_King_KT.png"} 'King files Index 43 - 50
    Dim str_select() As String = {"", ""}
    Dim str_board(64) As String 'In format of "#?" Where # is 0 - 2 and ? is 0 - 6. Each index correlates to a tile on the board
    '#
    '0: Black
    '1: White
    '2: None
    '3: Kill Black
    '4: Kill White
    '5: Selectable
    '?
    '0: Pawn
    '1: Rook
    '2: Knight
    '3: Bishop
    '4: Queen
    '5: King
    '6: None
    Dim str_turn As String = "0"
    Dim str_enemy As String = "1"
    Dim int_pic As Integer
    Dim int_pic2 As Integer

    Private Sub TableSet() 'Sets the board. Calls on images files from str_Pics using their indexes
        '1st row
        pic_1.Image = Image.FromFile(str_Pics(13))
        pic_2.Image = Image.FromFile(str_Pics(22))
        pic_3.Image = Image.FromFile(str_Pics(29))
        pic_4.Image = Image.FromFile(str_Pics(46))
        pic_5.Image = Image.FromFile(str_Pics(37))
        pic_6.Image = Image.FromFile(str_Pics(30))
        pic_7.Image = Image.FromFile(str_Pics(21))
        pic_8.Image = Image.FromFile(str_Pics(14))
        str_board(0) = "01"
        str_board(1) = "02"
        str_board(2) = "03"
        str_board(3) = "05"
        str_board(4) = "04"
        str_board(5) = "03"
        str_board(6) = "02"
        str_board(7) = "01"

        '2nd row
        pic_9.Image = Image.FromFile(str_Pics(6))
        pic_10.Image = Image.FromFile(str_Pics(5))
        pic_11.Image = Image.FromFile(str_Pics(6))
        pic_12.Image = Image.FromFile(str_Pics(5))
        pic_13.Image = Image.FromFile(str_Pics(6))
        pic_14.Image = Image.FromFile(str_Pics(5))
        pic_15.Image = Image.FromFile(str_Pics(6))
        pic_16.Image = Image.FromFile(str_Pics(5))
        str_board(8) = "00"
        str_board(9) = "00"
        str_board(10) = "00"
        str_board(11) = "00"
        str_board(12) = "00"
        str_board(13) = "00"
        str_board(14) = "00"
        str_board(15) = "00"

        '3rd row
        pic_17.Image = Image.FromFile(str_Pics(0))
        pic_18.Image = Image.FromFile(str_Pics(1))
        pic_19.Image = Image.FromFile(str_Pics(0))
        pic_20.Image = Image.FromFile(str_Pics(1))
        pic_21.Image = Image.FromFile(str_Pics(0))
        pic_22.Image = Image.FromFile(str_Pics(1))
        pic_23.Image = Image.FromFile(str_Pics(0))
        pic_24.Image = Image.FromFile(str_Pics(1))
        str_board(16) = "26"
        str_board(17) = "26"
        str_board(18) = "26"
        str_board(19) = "26"
        str_board(20) = "26"
        str_board(21) = "26"
        str_board(22) = "26"
        str_board(23) = "26"

        '4th row
        pic_25.Image = Image.FromFile(str_Pics(1))
        pic_26.Image = Image.FromFile(str_Pics(0))
        pic_27.Image = Image.FromFile(str_Pics(1))
        pic_28.Image = Image.FromFile(str_Pics(0))
        pic_29.Image = Image.FromFile(str_Pics(1))
        pic_30.Image = Image.FromFile(str_Pics(0))
        pic_31.Image = Image.FromFile(str_Pics(1))
        pic_32.Image = Image.FromFile(str_Pics(0))
        str_board(24) = "26"
        str_board(25) = "26"
        str_board(26) = "26"
        str_board(27) = "26"
        str_board(28) = "26"
        str_board(29) = "26"
        str_board(30) = "26"
        str_board(31) = "26"

        '5th row
        pic_33.Image = Image.FromFile(str_Pics(0))
        pic_34.Image = Image.FromFile(str_Pics(1))
        pic_35.Image = Image.FromFile(str_Pics(0))
        pic_36.Image = Image.FromFile(str_Pics(1))
        pic_37.Image = Image.FromFile(str_Pics(0))
        pic_38.Image = Image.FromFile(str_Pics(1))
        pic_39.Image = Image.FromFile(str_Pics(0))
        pic_40.Image = Image.FromFile(str_Pics(1))
        str_board(32) = "26"
        str_board(33) = "26"
        str_board(34) = "26"
        str_board(35) = "26"
        str_board(36) = "26"
        str_board(37) = "26"
        str_board(38) = "26"
        str_board(39) = "26"

        '6th row
        pic_41.Image = Image.FromFile(str_Pics(1))
        pic_42.Image = Image.FromFile(str_Pics(0))
        pic_43.Image = Image.FromFile(str_Pics(1))
        pic_44.Image = Image.FromFile(str_Pics(0))
        pic_45.Image = Image.FromFile(str_Pics(1))
        pic_46.Image = Image.FromFile(str_Pics(0))
        pic_47.Image = Image.FromFile(str_Pics(1))
        pic_48.Image = Image.FromFile(str_Pics(0))
        str_board(40) = "26"
        str_board(41) = "26"
        str_board(42) = "26"
        str_board(43) = "26"
        str_board(44) = "26"
        str_board(45) = "26"
        str_board(46) = "26"
        str_board(47) = "26"

        '7th row
        pic_49.Image = Image.FromFile(str_Pics(3))
        pic_50.Image = Image.FromFile(str_Pics(4))
        pic_51.Image = Image.FromFile(str_Pics(3))
        pic_52.Image = Image.FromFile(str_Pics(4))
        pic_53.Image = Image.FromFile(str_Pics(3))
        pic_54.Image = Image.FromFile(str_Pics(4))
        pic_55.Image = Image.FromFile(str_Pics(3))
        pic_56.Image = Image.FromFile(str_Pics(4))
        str_board(48) = "10"
        str_board(49) = "10"
        str_board(50) = "10"
        str_board(51) = "10"
        str_board(52) = "10"
        str_board(53) = "10"
        str_board(54) = "10"
        str_board(55) = "10"

        '8th row
        pic_57.Image = Image.FromFile(str_Pics(12))
        pic_58.Image = Image.FromFile(str_Pics(19))
        pic_59.Image = Image.FromFile(str_Pics(28))
        pic_60.Image = Image.FromFile(str_Pics(35))
        pic_61.Image = Image.FromFile(str_Pics(44))
        pic_62.Image = Image.FromFile(str_Pics(27))
        pic_63.Image = Image.FromFile(str_Pics(20))
        pic_64.Image = Image.FromFile(str_Pics(11))
        str_board(56) = "11"
        str_board(57) = "12"
        str_board(58) = "13"
        str_board(59) = "14"
        str_board(60) = "15"
        str_board(61) = "13"
        str_board(62) = "12"
        str_board(63) = "11"
    End Sub

    'Changes value in str_board based on a given file and pic number
    Private Function SetStrBoard(file As String) As String
        Dim str_newboard As String = ""
        'Tests for black team identifier. Places kill identifer if applicable
        If file.Substring(7, 1) = "B" Then
            If file.Substring(file.Length - 6, 2) = "KT" Then
                str_newboard += "3"
            Else
                str_newboard += "0"
            End If
            'Tests for white team identifier. Places kill identifier if applicable
        ElseIf file.Substring(7, 1) = "W" Then
            If file.Substring(file.Length - 6, 2) = "KT" Then
                str_newboard += "4"
            Else
                str_newboard += "1"
            End If
            'Tests for unoccupied identifier. Places selectable identifier if applicable
        ElseIf file.Substring(7, 1) = "U" Then
            If file.Substring(file.Length - 6, 2) = "ST" Then
                str_newboard += "5"
            Else
                str_newboard += "2"
            End If
        End If
        'Adds class identifier
        If file.Substring(9, 2) = "Pa" Then 'Pawn
            str_newboard += "0"
        ElseIf file.Substring(9, 2) = "Ro" Then 'Rook
            str_newboard += "1"
        ElseIf file.Substring(9, 2) = "Kn" Then 'Knight
            str_newboard += "2"
        ElseIf file.Substring(9, 2) = "Bi" Then 'Bishop
            str_newboard += "3"
        ElseIf file.Substring(9, 2) = "Qu" Then 'Queen
            str_newboard += "4"
        ElseIf file.Substring(9, 2) = "Ki" Then 'King
            str_newboard += "5"
        Else
            str_newboard += "6" 'Empty
        End If
        Return str_newboard
    End Function

    'Honestly could be removed
    Private Function IdentifyPiece(pic As Integer) As String
        Dim str_piece As String = ""
        str_piece = str_board(pic)
        Return str_piece
    End Function

    'Sends pic number to a given method based on whether or not it is a piece or move selection
    Private Sub PicClick(pic As Integer)
        'Click selects a piece
        If str_select(0) = "" Then
            int_pic = pic
            str_select(0) = IdentifyPiece(int_pic)
            MovePossiblities()
            'Click selects a possible move
        Else
            int_pic2 = pic
            str_select(1) = IdentifyPiece(int_pic2)
            If str_select(1).Substring(0, 1) = str_select(0).Substring(0, 1) Then
                str_select(0) = str_select(1)
                str_select(1) = ""
                ResetBW()
                If int_pic = int_pic2 Then
                    str_select(0) = ""
                Else
                    int_pic = int_pic2
                    MovePossiblities()
                End If
            ElseIf str_select(1).Substring(0, 1) IsNot "3" And str_select(1).Substring(0, 1) IsNot "4" And str_select(1).Substring(0, 1) IsNot "5" Then
                str_select(0) = ""
                str_select(1) = ""
                ResetBW()
            Else
                ExecuteMove()
            End If
        End If
    End Sub

    'Shows the player all possible moves based on the piece's identifier
    Private Sub MovePossiblities()
        'Resets the click pair if the first click is on an empty or enemy tile
        If str_select(0).Substring(0, 1) = "2" OrElse str_select(0).Substring(0, 1) Like str_enemy Then
            str_select(0) = ""
        Else
            Select Case (str_select(0).Substring(1, 1))
                Case "0" : Pawn()
                Case "1" : Rook()
                Case "2" : Knight()
                Case "3" : Bishop()
                Case "4" : Queen()
                Case "5" : King()
            End Select
        End If
    End Sub

    Private Sub ExecuteMove()
        Dim str_tile As String = ""
        If str_select(1).Substring(0, 1) = "3" OrElse str_select(1).Substring(0, 1) = "4" OrElse str_select(1).Substring(0, 1) = "5" Then
            str_board(int_pic2) = str_board(int_pic)
            str_board(int_pic) = "26"
            If str_select(1).Substring(1, 1) = "5" Then
                Close()
            End If
            ResetBW()
            str_tile = BlankBoard(int_pic2)
            PieceReset(str_tile, int_pic2)
            str_tile = BlankBoard(int_pic)
            PieceReset(str_tile, int_pic)
            If str_turn = "0" Then
                str_turn = "1"
                str_enemy = "0"
            Else
                str_turn = "0"
                str_enemy = "1"
            End If
        End If
        str_select(0) = ""
        str_select(1) = ""
    End Sub

    Private Sub ResetBW()
        Dim count As Integer
        Dim str_tile As String
        For count = 0 To 63 Step 1
            str_tile = BlankBoard(count)
            Select Case (str_board(count).Substring(0, 1))
                Case "3"
                    PieceReset(str_tile, count)
                Case "4"
                    PieceReset(str_tile, count)
                Case "5"
                    PieceReset(str_tile, count)
            End Select
        Next
    End Sub

    Private Function BlankBoard(pic As Integer) As String
        Dim str_tile As String = ""
        Select Case (pic)
            Case Is = 0
                str_tile = "W"
            Case Is = 2
                str_tile = "W"
            Case Is = 4
                str_tile = "W"
            Case Is = 6
                str_tile = "W"
            Case Is = 9
                str_tile = "W"
            Case Is = 11
                str_tile = "W"
            Case Is = 13
                str_tile = "W"
            Case Is = 15
                str_tile = "W"
            Case Is = 16
                str_tile = "W"
            Case Is = 18
                str_tile = "W"
            Case Is = 20
                str_tile = "W"
            Case Is = 22
                str_tile = "W"
            Case Is = 25
                str_tile = "W"
            Case Is = 27
                str_tile = "W"
            Case Is = 29
                str_tile = "W"
            Case Is = 31
                str_tile = "W"
            Case Is = 32
                str_tile = "W"
            Case Is = 34
                str_tile = "W"
            Case Is = 36
                str_tile = "W"
            Case Is = 38
                str_tile = "W"
            Case Is = 41
                str_tile = "W"
            Case Is = 43
                str_tile = "W"
            Case Is = 45
                str_tile = "W"
            Case Is = 47
                str_tile = "W"
            Case Is = 48
                str_tile = "W"
            Case Is = 50
                str_tile = "W"
            Case Is = 52
                str_tile = "W"
            Case Is = 54
                str_tile = "W"
            Case Is = 57
                str_tile = "W"
            Case Is = 59
                str_tile = "W"
            Case Is = 61
                str_tile = "W"
            Case Is = 63
                str_tile = "W"
            Case Else
                str_tile = "B"
        End Select
        Return str_tile
    End Function

    Private Sub PieceReset(str_tile As String, pic As Integer)
        Select Case (str_board(pic).Substring(1, 1))
            Case "0" : Select Case (str_board(pic).Substring(0, 1))
                    Case "0"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(6))
                            Case "W" : ChangePic(pic, str_Pics(5))
                        End Select
                    Case "1"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(4))
                            Case "W" : ChangePic(pic, str_Pics(3))
                        End Select
                    Case "3"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(6))
                            Case "W" : ChangePic(pic, str_Pics(5))
                        End Select
                    Case "4"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(4))
                            Case "W" : ChangePic(pic, str_Pics(3))
                        End Select
                End Select
            Case "1" : Select Case (str_board(pic).Substring(0, 1))
                    Case "0"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(14))
                            Case "W" : ChangePic(pic, str_Pics(13))
                        End Select
                    Case "1"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(12))
                            Case "W" : ChangePic(pic, str_Pics(11))
                        End Select
                    Case "3"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(14))
                            Case "W" : ChangePic(pic, str_Pics(13))
                        End Select
                    Case "4"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(12))
                            Case "W" : ChangePic(pic, str_Pics(11))
                        End Select
                End Select
            Case "2" : Select Case (str_board(pic).Substring(0, 1))
                    Case "0"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(22))
                            Case "W" : ChangePic(pic, str_Pics(21))
                        End Select
                    Case "1"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(20))
                            Case "W" : ChangePic(pic, str_Pics(19))
                        End Select
                    Case "3"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(22))
                            Case "W" : ChangePic(pic, str_Pics(21))
                        End Select
                    Case "4"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(20))
                            Case "W" : ChangePic(pic, str_Pics(19))
                        End Select
                End Select
            Case "3" : Select Case (str_board(pic).Substring(0, 1))
                    Case "0"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(30))
                            Case "W" : ChangePic(pic, str_Pics(29))
                        End Select
                    Case "1"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(28))
                            Case "W" : ChangePic(pic, str_Pics(27))
                        End Select
                    Case "3"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(30))
                            Case "W" : ChangePic(pic, str_Pics(29))
                        End Select
                    Case "4"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(28))
                            Case "W" : ChangePic(pic, str_Pics(27))
                        End Select
                End Select
            Case "4" : Select Case (str_board(pic).Substring(0, 1))
                    Case "0"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(38))
                            Case "W" : ChangePic(pic, str_Pics(37))
                        End Select
                    Case "1"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(36))
                            Case "W" : ChangePic(pic, str_Pics(35))
                        End Select
                    Case "3"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(38))
                            Case "W" : ChangePic(pic, str_Pics(37))
                        End Select
                    Case "4"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(36))
                            Case "W" : ChangePic(pic, str_Pics(35))
                        End Select
                End Select
            Case "5" : Select Case (str_board(pic).Substring(0, 1))
                    Case "0"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(46))
                            Case "W" : ChangePic(pic, str_Pics(45))
                        End Select
                    Case "1"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(44))
                            Case "W" : ChangePic(pic, str_Pics(43))
                        End Select
                    Case "3"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(46))
                            Case "W" : ChangePic(pic, str_Pics(45))
                        End Select
                    Case "4"
                        Select Case (str_tile)
                            Case "B" : ChangePic(pic, str_Pics(44))
                            Case "W" : ChangePic(pic, str_Pics(43))
                        End Select
                End Select
            Case "6" : Select Case (str_tile)
                    Case "B" : ChangePic(pic, str_Pics(1))
                    Case "W" : ChangePic(pic, str_Pics(0))
                End Select
        End Select
    End Sub

    Private Sub ChangePic(pic As Integer, file As String)
        Dim str_newboard As String
        str_newboard = SetStrBoard(file)
        str_board(pic) = str_newboard
        Select Case (pic)
            Case 0 : pic_1.Image = Image.FromFile(file)
            Case 1 : pic_2.Image = Image.FromFile(file)
            Case 2 : pic_3.Image = Image.FromFile(file)
            Case 3 : pic_4.Image = Image.FromFile(file)
            Case 4 : pic_5.Image = Image.FromFile(file)
            Case 5 : pic_6.Image = Image.FromFile(file)
            Case 6 : pic_7.Image = Image.FromFile(file)
            Case 7 : pic_8.Image = Image.FromFile(file)
            Case 8 : pic_9.Image = Image.FromFile(file)
            Case 9 : pic_10.Image = Image.FromFile(file)
            Case 10 : pic_11.Image = Image.FromFile(file)
            Case 11 : pic_12.Image = Image.FromFile(file)
            Case 12 : pic_13.Image = Image.FromFile(file)
            Case 13 : pic_14.Image = Image.FromFile(file)
            Case 14 : pic_15.Image = Image.FromFile(file)
            Case 15 : pic_16.Image = Image.FromFile(file)
            Case 16 : pic_17.Image = Image.FromFile(file)
            Case 17 : pic_18.Image = Image.FromFile(file)
            Case 18 : pic_19.Image = Image.FromFile(file)
            Case 19 : pic_20.Image = Image.FromFile(file)
            Case 20 : pic_21.Image = Image.FromFile(file)
            Case 21 : pic_22.Image = Image.FromFile(file)
            Case 22 : pic_23.Image = Image.FromFile(file)
            Case 23 : pic_24.Image = Image.FromFile(file)
            Case 24 : pic_25.Image = Image.FromFile(file)
            Case 25 : pic_26.Image = Image.FromFile(file)
            Case 26 : pic_27.Image = Image.FromFile(file)
            Case 27 : pic_28.Image = Image.FromFile(file)
            Case 28 : pic_29.Image = Image.FromFile(file)
            Case 29 : pic_30.Image = Image.FromFile(file)
            Case 30 : pic_31.Image = Image.FromFile(file)
            Case 31 : pic_32.Image = Image.FromFile(file)
            Case 32 : pic_33.Image = Image.FromFile(file)
            Case 33 : pic_34.Image = Image.FromFile(file)
            Case 34 : pic_35.Image = Image.FromFile(file)
            Case 35 : pic_36.Image = Image.FromFile(file)
            Case 36 : pic_37.Image = Image.FromFile(file)
            Case 37 : pic_38.Image = Image.FromFile(file)
            Case 38 : pic_39.Image = Image.FromFile(file)
            Case 39 : pic_40.Image = Image.FromFile(file)
            Case 40 : pic_41.Image = Image.FromFile(file)
            Case 41 : pic_42.Image = Image.FromFile(file)
            Case 42 : pic_43.Image = Image.FromFile(file)
            Case 43 : pic_44.Image = Image.FromFile(file)
            Case 44 : pic_45.Image = Image.FromFile(file)
            Case 45 : pic_46.Image = Image.FromFile(file)
            Case 46 : pic_47.Image = Image.FromFile(file)
            Case 47 : pic_48.Image = Image.FromFile(file)
            Case 48 : pic_49.Image = Image.FromFile(file)
            Case 49 : pic_50.Image = Image.FromFile(file)
            Case 50 : pic_51.Image = Image.FromFile(file)
            Case 51 : pic_52.Image = Image.FromFile(file)
            Case 52 : pic_53.Image = Image.FromFile(file)
            Case 53 : pic_54.Image = Image.FromFile(file)
            Case 54 : pic_55.Image = Image.FromFile(file)
            Case 55 : pic_56.Image = Image.FromFile(file)
            Case 56 : pic_57.Image = Image.FromFile(file)
            Case 57 : pic_58.Image = Image.FromFile(file)
            Case 58 : pic_59.Image = Image.FromFile(file)
            Case 59 : pic_60.Image = Image.FromFile(file)
            Case 60 : pic_61.Image = Image.FromFile(file)
            Case 61 : pic_62.Image = Image.FromFile(file)
            Case 62 : pic_63.Image = Image.FromFile(file)
            Case 63 : pic_64.Image = Image.FromFile(file)
        End Select
    End Sub

    Private Sub PlaceKT(str_moveto As String, int_loop As Integer)
        If str_moveto.Substring(0, 1) = "0" And str_turn = "1" Then
            If str_moveto.Substring(1, 1) = "0" Then 'Changes to Pawn Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(10))
            ElseIf str_moveto.Substring(1, 1) = "1" Then 'Changes to Rook Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(18))
            ElseIf str_moveto.Substring(1, 1) = "2" Then 'Changes to Knight Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(26))
            ElseIf str_moveto.Substring(1, 1) = "3" Then 'Changes to Bishop Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(34))
            ElseIf str_moveto.Substring(1, 1) = "4" Then 'Changes to Queen Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(42))
            ElseIf str_moveto.Substring(1, 1) = "5" Then 'Changes to King Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(50))
            End If
        ElseIf str_moveto.Substring(0, 1) = "1" And str_turn = "0" Then
            If str_moveto.Substring(1, 1) = "0" Then 'Changes to Pawn Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(8))
            ElseIf str_moveto.Substring(1, 1) = "1" Then 'Changes to Rook Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(16))
            ElseIf str_moveto.Substring(1, 1) = "2" Then 'Changes to Knight Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(24))
            ElseIf str_moveto.Substring(1, 1) = "3" Then 'Changes to Bishop Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(32))
            ElseIf str_moveto.Substring(1, 1) = "4" Then 'Changes to Queen Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(40))
            ElseIf str_moveto.Substring(1, 1) = "5" Then 'Changes to King Kill Tile
                ChangePic(int_pic - int_loop, str_Pics(48))
            End If
        End If
    End Sub

    Private Sub Pawn()
        Dim str_moveto As String
        'Parameters for a White Pawn
        If (int_pic - 8) >= 0 And str_turn = "1" Then
            str_moveto = IdentifyPiece(int_pic - 8) 'Tile directly above piece
            'Tests for empty space in tile directly above piece
            If str_moveto.Substring(0, 1) = "2" Then
                ChangePic(int_pic - 8, str_Pics(2))
            End If
            'Highlights enemy pieces diagonally left to the piece. Excludes pieces the are within the far left column
            If (int_pic Mod 8) > 0 Then
                str_moveto = IdentifyPiece(int_pic - 9) 'Tile diagonally left to piece
                If str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, 9)
                End If
            End If
                'Highlights enemy pieces diagonally right to the piece. Excludes pieces the are within the far right column
                If (int_pic Mod 8) < 7 Then
                str_moveto = IdentifyPiece(int_pic - 7) 'Tile diagonally right to piece
                If str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, 7)
                End If
            End If
                'Parameters for a Black Pawn
            ElseIf (int_pic + 8) <= 63 And str_turn = "0" Then
            str_moveto = IdentifyPiece(int_pic + 8) 'Tile directly below piece
            'Tests for empty space in tile directly below piece
            If str_moveto.Substring(0, 1) = "2" Then
                ChangePic(int_pic + 8, str_Pics(2))
            End If
            'Highlights enemy pieces diagonally left to the piece. Excludes pieces the are within the far left column
            If (int_pic Mod 8) > 0 Then
                str_moveto = IdentifyPiece(int_pic + 7) 'Tile diagonally left to piece
                If str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, -7)
                End If
            End If
                'Highlights enemy pieces diagonally right to the piece. Excludes pieces the are within the far right column
                If (int_pic Mod 8) < 7 Then
                str_moveto = IdentifyPiece(int_pic + 9) 'Tile diagonally right to piece
                If str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, -9)
                End If
            End If
            End If
    End Sub

    Private Sub Rook()
        Dim str_moveto As String = ""
        Dim int_loop As Integer = 0
        'Parameters for both White and Black Rooks
        'Test tiles to the left of the Rook. Excludes pieces already in the far left column
        If (int_pic Mod 8) > 0 Then
            int_loop = 1
            str_moveto = IdentifyPiece(int_pic - int_loop)
            While str_moveto = "26" And ((int_pic - int_loop) Mod 8) < 7 And (int_pic - int_loop) >= 0
                ChangePic(int_pic - int_loop, str_Pics(2))
                int_loop += 1
                If ((int_pic - int_loop) Mod 8) < 7 And (int_pic - int_loop) >= 0 Then
                    str_moveto = IdentifyPiece(int_pic - int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) = str_enemy Then
                PlaceKT(str_moveto, int_loop)
            End If
            str_moveto = ""
        End If

        'Test tiles to the right of the Rook. Excludes pieces already in the far right column
        If (int_pic Mod 8) < 7 Then
            int_loop = 1
            str_moveto = IdentifyPiece(int_pic + int_loop)
            While str_moveto = "26" And ((int_pic + int_loop) Mod 8) > 0
                ChangePic(int_pic + int_loop, str_Pics(2))
                int_loop += 1
                If ((int_pic + int_loop) Mod 8) > 0 Then
                    str_moveto = IdentifyPiece(int_pic + int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) = str_enemy Then
                PlaceKT(str_moveto, -int_loop)
            End If
            str_moveto = ""
        End If

        'Test tiles above the Rook. Excludes pieces already in the top row
        If int_pic > 7 Then
            int_loop = 8
            str_moveto = IdentifyPiece(int_pic - int_loop)
            While str_moveto = "26" And (int_pic - int_loop) >= 0
                ChangePic(int_pic - int_loop, str_Pics(2))
                int_loop += 8
                If (int_pic - int_loop) >= 0 Then
                    str_moveto = IdentifyPiece(int_pic - int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) = str_enemy Then
                PlaceKT(str_moveto, int_loop)
            End If
            str_moveto = ""
        End If

        'Test tiles below the Rook. Excludes pieces already in the bottom row
        If int_pic < 56 Then
            int_loop = 8
            str_moveto = IdentifyPiece(int_pic + int_loop)
            While str_moveto = "26" And (int_pic + int_loop) <= 63
                ChangePic(int_pic + int_loop, str_Pics(2))
                int_loop += 8
                If (int_pic + int_loop) <= 63 Then
                    str_moveto = IdentifyPiece(int_pic + int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) = str_enemy Then
                PlaceKT(str_moveto, -int_loop)
            End If
            str_moveto = ""
        End If
    End Sub

    Private Sub Knight()
        Dim str_moveto As String
        'Leftmost positions
        If (int_pic Mod 8) >= 2 Then
            'Upper
            If int_pic > 7 Then
                str_moveto = IdentifyPiece(int_pic - 10)
                If str_moveto = "26" Then
                    ChangePic(int_pic - 10, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, 10)
                End If
            End If
            'Lower
            If int_pic < 56 Then
                str_moveto = IdentifyPiece(int_pic + 6)
                If str_moveto = "26" Then
                    ChangePic(int_pic + 6, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, -6)
                End If
            End If
        End If

        'Top positions
        If int_pic > 15 Then
            'Left
            If (int_pic Mod 8) > 0 Then
                str_moveto = IdentifyPiece(int_pic - 17)
                If str_moveto = "26" Then
                    ChangePic(int_pic - 17, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, 17)
                End If
            End If
            'Right
            If (int_pic Mod 8) < 7 Then
                str_moveto = IdentifyPiece(int_pic - 15)
                If str_moveto = "26" Then
                    ChangePic(int_pic - 15, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, 15)
                End If
            End If
        End If

        'Rightmost positions
        If (int_pic Mod 8) <= 5 Then
            'Upper
            If int_pic > 7 Then
                str_moveto = IdentifyPiece(int_pic - 6)
                If str_moveto = "26" Then
                    ChangePic(int_pic - 6, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, 6)
                End If
            End If
            'Lower
            If int_pic < 56 Then
                str_moveto = IdentifyPiece(int_pic + 10)
                If str_moveto = "26" Then
                    ChangePic(int_pic + 10, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, -10)
                End If
            End If
        End If

        'Bottom positions
        If int_pic < 48 Then
            'Left
            If (int_pic Mod 8) > 0 Then
                str_moveto = IdentifyPiece(int_pic + 15)
                If str_moveto = "26" Then
                    ChangePic(int_pic + 15, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, -15)
                End If
            End If
            'Right
            If (int_pic Mod 8) < 7 Then
                str_moveto = IdentifyPiece(int_pic + 17)
                If str_moveto = "26" Then
                    ChangePic(int_pic + 17, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) = str_enemy Then
                    PlaceKT(str_moveto, -17)
                End If
            End If
        End If
    End Sub

    Private Sub Bishop()
        Dim str_moveto As String
        Dim int_loop As Integer
        'Parameters for both White and Black Bishops
        'Tests tiles to the upper right of the Bishop. Excludes pieces in far right column or top row
        If (int_pic Mod 8) < 7 And int_pic > 7 Then
            int_loop = 7
            str_moveto = IdentifyPiece(int_pic - int_loop)
            While str_moveto = "26" And (int_pic - int_loop) >= 0 And ((int_pic - int_loop) Mod 8) > 0
                ChangePic(int_pic - int_loop, str_Pics(2))
                int_loop += 7
                If (int_pic - int_loop) >= 0 And ((int_pic - int_loop) Mod 8) > 0 Then
                    str_moveto = IdentifyPiece(int_pic - int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, int_loop)
            End If
        End If

        'Tests tiles to the upper left of the Bishop. Excludes pieces in far left column or top row
        If (int_pic Mod 8) > 0 And int_pic > 7 Then
            int_loop = 9
            str_moveto = IdentifyPiece(int_pic - int_loop)
            While str_moveto = "26" And (int_pic - int_loop) >= 0 And ((int_pic - int_loop) Mod 8) < 7
                ChangePic(int_pic - int_loop, str_Pics(2))
                int_loop += 9
                If (int_pic - int_loop) >= 0 And ((int_pic - int_loop) Mod 8) < 7 Then
                    str_moveto = IdentifyPiece(int_pic - int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, int_loop)
            End If
        End If

        'Tests tiles to the lower left of the Bishop. Excludes pieces in far right column or bottom row
        If (int_pic Mod 8) > 0 And int_pic < 56 Then
            int_loop = 7
            str_moveto = IdentifyPiece(int_pic + int_loop)
            While str_moveto = "26" And (int_pic + int_loop) <= 63 And ((int_pic + int_loop) Mod 8) < 7
                ChangePic(int_pic + int_loop, str_Pics(2))
                int_loop += 7
                If (int_pic + int_loop) <= 63 And ((int_pic + int_loop) Mod 8) < 7 Then
                    str_moveto = IdentifyPiece(int_pic + int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, -int_loop)
            End If
        End If

        'Tests tiles to the lower right of the Bishop. Excludes pieces in far left column or bottom row
        If (int_pic Mod 8) < 7 And int_pic < 56 Then
            int_loop = 9
            str_moveto = IdentifyPiece(int_pic + int_loop)
            While str_moveto = "26" And (int_pic + int_loop) <= 63 And ((int_pic + int_loop) Mod 8) > 0
                ChangePic(int_pic + int_loop, str_Pics(2))
                int_loop += 9
                If (int_pic + int_loop) <= 63 And ((int_pic + int_loop) Mod 8) > 0 Then
                    str_moveto = IdentifyPiece(int_pic + int_loop)
                End If
            End While
            If str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, -int_loop)
            End If
        End If
    End Sub

    Private Sub Queen()
        'Reuses Bishop and Rook move sets
        Bishop()
        Rook()
    End Sub

    Private Sub King()
        Dim str_moveto As String
        If (int_pic Mod 8) > 0 Then
            str_moveto = IdentifyPiece(int_pic - 1)
            If str_moveto.Substring(0, 1) = "2" Then
                ChangePic(int_pic - 1, str_Pics(2))
            ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, 1)
            End If
            If int_pic > 7 Then
                str_moveto = IdentifyPiece(int_pic - 9)
                If str_moveto.Substring(0, 1) = "2" Then
                    ChangePic(int_pic - 9, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                    PlaceKT(str_moveto, 9)
                End If
            End If
            If int_pic < 56 Then
                str_moveto = IdentifyPiece(int_pic + 7)
                If str_moveto.Substring(0, 1) = "2" Then
                    ChangePic(int_pic + 7, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                    PlaceKT(str_moveto, -7)
                End If
            End If
        End If

        If (int_pic Mod 8) < 7 Then
            str_moveto = IdentifyPiece(int_pic + 1)
            If str_moveto.Substring(0, 1) = "2" Then
                ChangePic(int_pic + 1, str_Pics(2))
            ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, -1)
            End If
            If int_pic > 7 Then
                str_moveto = IdentifyPiece(int_pic - 7)
                If str_moveto.Substring(0, 1) = "2" Then
                    ChangePic(int_pic - 7, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                    PlaceKT(str_moveto, 7)
                End If
            End If
            If int_pic < 56 Then
                str_moveto = IdentifyPiece(int_pic + 9)
                If str_moveto.Substring(0, 1) = "2" Then
                    ChangePic(int_pic + 9, str_Pics(2))
                ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                    PlaceKT(str_moveto, -9)
                End If
            End If
        End If

        If int_pic > 7 Then
            str_moveto = IdentifyPiece(int_pic - 8)
            If str_moveto.Substring(0, 1) = "2" Then
                ChangePic(int_pic - 8, str_Pics(2))
            ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, 8)
            End If
        End If

        If int_pic < 56 Then
            str_moveto = IdentifyPiece(int_pic + 8)
            If str_moveto.Substring(0, 1) = "2" Then
                ChangePic(int_pic + 8, str_Pics(2))
            ElseIf str_moveto.Substring(0, 1) IsNot str_turn Then
                PlaceKT(str_moveto, -8)
            End If
        End If
    End Sub
    'Sets the board upon form load
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TableSet()
    End Sub

    'Closes the program
    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Close()
    End Sub

    'Prompts the user for confirmation before closing the program
    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim exitOrx As DialogResult
        exitOrx = MessageBox.Show("Do you want to close the program?", "Closing Program",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
        If exitOrx = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    'Updates Date and Time labels on timer tick
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_Date.Text = DateTime.Now.ToLongDateString
        lbl_Time.Text = DateTime.Now.ToLongTimeString
    End Sub

    Private Sub pic_1_Click(sender As Object, e As EventArgs) Handles pic_1.Click
        PicClick(0)
    End Sub
    Private Sub pic_2_Click(sender As Object, e As EventArgs) Handles pic_2.Click
        PicClick(1)
    End Sub
    Private Sub pic_3_Click(sender As Object, e As EventArgs) Handles pic_3.Click
        PicClick(2)
    End Sub
    Private Sub pic_4_Click(sender As Object, e As EventArgs) Handles pic_4.Click
        PicClick(3)
    End Sub
    Private Sub pic_5_Click(sender As Object, e As EventArgs) Handles pic_5.Click
        PicClick(4)
    End Sub
    Private Sub pic_6_Click(sender As Object, e As EventArgs) Handles pic_6.Click
        PicClick(5)
    End Sub
    Private Sub pic_7_Click(sender As Object, e As EventArgs) Handles pic_7.Click
        PicClick(6)
    End Sub
    Private Sub pic_8_Click(sender As Object, e As EventArgs) Handles pic_8.Click
        PicClick(7)
    End Sub
    Private Sub pic_9_Click(sender As Object, e As EventArgs) Handles pic_9.Click
        PicClick(8)
    End Sub
    Private Sub pic_10_Click(sender As Object, e As EventArgs) Handles pic_10.Click
        PicClick(9)
    End Sub
    Private Sub pic_11_Click(sender As Object, e As EventArgs) Handles pic_11.Click
        PicClick(10)
    End Sub
    Private Sub pic_12_Click(sender As Object, e As EventArgs) Handles pic_12.Click
        PicClick(11)
    End Sub
    Private Sub pic_13_Click(sender As Object, e As EventArgs) Handles pic_13.Click
        PicClick(12)
    End Sub
    Private Sub pic_14_Click(sender As Object, e As EventArgs) Handles pic_14.Click
        PicClick(13)
    End Sub
    Private Sub pic_15_Click(sender As Object, e As EventArgs) Handles pic_15.Click
        PicClick(14)
    End Sub
    Private Sub pic_16_Click(sender As Object, e As EventArgs) Handles pic_16.Click
        PicClick(15)
    End Sub
    Private Sub pic_17_Click(sender As Object, e As EventArgs) Handles pic_17.Click
        PicClick(16)
    End Sub
    Private Sub pic_18_Click(sender As Object, e As EventArgs) Handles pic_18.Click
        PicClick(17)
    End Sub
    Private Sub pic_19_Click(sender As Object, e As EventArgs) Handles pic_19.Click
        PicClick(18)
    End Sub
    Private Sub pic_20_Click(sender As Object, e As EventArgs) Handles pic_20.Click
        PicClick(19)
    End Sub
    Private Sub pic_21_Click(sender As Object, e As EventArgs) Handles pic_21.Click
        PicClick(20)
    End Sub
    Private Sub pic_22_Click(sender As Object, e As EventArgs) Handles pic_22.Click
        PicClick(21)
    End Sub
    Private Sub pic_23_Click(sender As Object, e As EventArgs) Handles pic_23.Click
        PicClick(22)
    End Sub
    Private Sub pic_24_Click(sender As Object, e As EventArgs) Handles pic_24.Click
        PicClick(23)
    End Sub
    Private Sub pic_25_Click(sender As Object, e As EventArgs) Handles pic_25.Click
        PicClick(24)
    End Sub
    Private Sub pic_26_Click(sender As Object, e As EventArgs) Handles pic_26.Click
        PicClick(25)
    End Sub
    Private Sub pic_27_Click(sender As Object, e As EventArgs) Handles pic_27.Click
        PicClick(26)
    End Sub
    Private Sub pic_28_Click(sender As Object, e As EventArgs) Handles pic_28.Click
        PicClick(27)
    End Sub
    Private Sub pic_29_Click(sender As Object, e As EventArgs) Handles pic_29.Click
        PicClick(28)
    End Sub
    Private Sub pic_30_Click(sender As Object, e As EventArgs) Handles pic_30.Click
        PicClick(29)
    End Sub
    Private Sub pic_31_Click(sender As Object, e As EventArgs) Handles pic_31.Click
        PicClick(30)
    End Sub
    Private Sub pic_32_Click(sender As Object, e As EventArgs) Handles pic_32.Click
        PicClick(31)
    End Sub
    Private Sub pic_33_Click(sender As Object, e As EventArgs) Handles pic_33.Click
        PicClick(32)
    End Sub
    Private Sub pic_34_Click(sender As Object, e As EventArgs) Handles pic_34.Click
        PicClick(33)
    End Sub
    Private Sub pic_35_Click(sender As Object, e As EventArgs) Handles pic_35.Click
        PicClick(34)
    End Sub
    Private Sub pic_36_Click(sender As Object, e As EventArgs) Handles pic_36.Click
        PicClick(35)
    End Sub
    Private Sub pic_37_Click(sender As Object, e As EventArgs) Handles pic_37.Click
        PicClick(36)
    End Sub
    Private Sub pic_38_Click(sender As Object, e As EventArgs) Handles pic_38.Click
        PicClick(37)
    End Sub
    Private Sub pic_39_Click(sender As Object, e As EventArgs) Handles pic_39.Click
        PicClick(38)
    End Sub
    Private Sub pic_40_Click(sender As Object, e As EventArgs) Handles pic_40.Click
        PicClick(39)
    End Sub
    Private Sub pic_41_Click(sender As Object, e As EventArgs) Handles pic_41.Click
        PicClick(40)
    End Sub
    Private Sub pic_42_Click(sender As Object, e As EventArgs) Handles pic_42.Click
        PicClick(41)
    End Sub
    Private Sub pic_43_Click(sender As Object, e As EventArgs) Handles pic_43.Click
        PicClick(42)
    End Sub
    Private Sub pic_44_Click(sender As Object, e As EventArgs) Handles pic_44.Click
        PicClick(43)
    End Sub
    Private Sub pic_45_Click(sender As Object, e As EventArgs) Handles pic_45.Click
        PicClick(44)
    End Sub
    Private Sub pic_46_Click(sender As Object, e As EventArgs) Handles pic_46.Click
        PicClick(45)
    End Sub
    Private Sub pic_47_Click(sender As Object, e As EventArgs) Handles pic_47.Click
        PicClick(46)
    End Sub
    Private Sub pic_48_Click(sender As Object, e As EventArgs) Handles pic_48.Click
        PicClick(47)
    End Sub
    Private Sub pic_49_Click(sender As Object, e As EventArgs) Handles pic_49.Click
        PicClick(48)
    End Sub
    Private Sub pic_50_Click(sender As Object, e As EventArgs) Handles pic_50.Click
        PicClick(49)
    End Sub
    Private Sub pic_51_Click(sender As Object, e As EventArgs) Handles pic_51.Click
        PicClick(50)
    End Sub
    Private Sub pic_52_Click(sender As Object, e As EventArgs) Handles pic_52.Click
        PicClick(51)
    End Sub
    Private Sub pic_53_Click(sender As Object, e As EventArgs) Handles pic_53.Click
        PicClick(52)
    End Sub
    Private Sub pic_54_Click(sender As Object, e As EventArgs) Handles pic_54.Click
        PicClick(53)
    End Sub
    Private Sub pic_55_Click(sender As Object, e As EventArgs) Handles pic_55.Click
        PicClick(54)
    End Sub
    Private Sub pic_56_Click(sender As Object, e As EventArgs) Handles pic_56.Click
        PicClick(55)
    End Sub
    Private Sub pic_57_Click(sender As Object, e As EventArgs) Handles pic_57.Click
        PicClick(56)
    End Sub
    Private Sub pic_58_Click(sender As Object, e As EventArgs) Handles pic_58.Click
        PicClick(57)
    End Sub
    Private Sub pic_59_Click(sender As Object, e As EventArgs) Handles pic_59.Click
        PicClick(58)
    End Sub
    Private Sub pic_60_Click(sender As Object, e As EventArgs) Handles pic_60.Click
        PicClick(59)
    End Sub
    Private Sub pic_61_Click(sender As Object, e As EventArgs) Handles pic_61.Click
        PicClick(60)
    End Sub
    Private Sub pic_62_Click(sender As Object, e As EventArgs) Handles pic_62.Click
        PicClick(61)
    End Sub
    Private Sub pic_63_Click(sender As Object, e As EventArgs) Handles pic_63.Click
        PicClick(62)
    End Sub
    Private Sub pic_64_Click(sender As Object, e As EventArgs) Handles pic_64.Click
        PicClick(63)
    End Sub
End Class