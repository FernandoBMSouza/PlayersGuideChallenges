using RoomCoordinates;

Coordinate[] coordinates = new Coordinate[6];

coordinates[0] = new Coordinate(1, 1);
coordinates[1] = new Coordinate(1, 2);
coordinates[2] = new Coordinate(1, 3);
coordinates[3] = new Coordinate(2, 1);
coordinates[4] = new Coordinate(2, 2);
coordinates[5] = new Coordinate(2, 3);

Console.WriteLine(Coordinate.AreAdjacent(coordinates[0], coordinates[1]));
Console.WriteLine(Coordinate.AreAdjacent(coordinates[0], coordinates[2]));