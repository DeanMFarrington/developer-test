While MVC is new to me, the project is very structured and so I was able to come up with solutions based upon what
I've learnt from the already developed functionality. The code itself, once again, is neat and very maintainable.

There is commonality found between classes that may benefit from a refactored implementation. One example of this
would be the requests for Offers and Viewings. Accept and Reject both work in a very similar manner, while changing
just the Status of the offer or request. Furthermore, the Status enum may possibly benefit from having a universal
'Status' enum as both OfferStatus, ViewingStatus and any potential further functionality implementations share the
common values 'Pending', 'Accepted' and 'Rejected'.

Personally, the biggest hurdle was that of code-first database design in which I have not had any prior experience
with. I have had previous experience with databases, but this proved to be very difficult as any errors related to
Migrations were hard to understand, but I believe by the end of the tasks I became better at resolving these issues.