from hypothesis import given, example
from hypothesis.strategies import text, characters

from solve import decode, encode


@given(text(alphabet=characters(whitelist_categories=('Lu', 'Ll', 'Pc')),
            min_size=1,
            max_size=100))
@example("HHHeellloWooorrrrlld!!")
def test_decode_inverts_encode(s):
    assert decode(encode(s)) == s


