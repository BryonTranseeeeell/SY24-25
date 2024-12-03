Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        dk.Visibility = Visibility.Visible
        Kam.Visibility = Visibility.Hidden
        rich.Visibility = Visibility.Hidden
        label.Content = "DeKyalin Metcalf a wide resiver or the seatle sea hawks Nickname-DK in 
highschool dk had over 1,226 runing yards totaling 14 career touchdowns 
where he was later drafted to the seahawks "
    End Sub

    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        dk.Visibility = Visibility.Hidden
        Kam.Visibility = Visibility.Visible
        rich.Visibility = Visibility.Hidden
        label.Content = "
Kam Chancellor was a safety and played for the Seahawks from 2010-2017. He was a four-time Pro Bowler
and was a member of the Seahawks during their back-to-back Super Bowl appearances in 2013 and 2014, 
including winning Super Bowl XLVIII.his nickmane- BAM BAM KAM"
    End Sub

    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles button2.Click
        dk.Visibility = Visibility.Hidden
        Kam.Visibility = Visibility.Hidden
        rich.Visibility = Visibility.Visible
        label.Content = "
Kam Chancellor was a safety and played for the Seahawks from 2010-2017. He was a four-time Pro Bowler
and was a member of the Seahawks during their back-to-back Super Bowl appearances in 2013 and 2014, 
including winning Super Bowl XLVIII.his nickmane- BAM BAM KAM"
    End Sub
End Class
