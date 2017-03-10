To do
1. Need to add the connector class to postgresl. The POCO is already there, just not the connector
2. We also need to limit the default get so it doesn't try to stream down all the data (given that it is over a gig in size)
3. Probably want to limit the attributes we return
