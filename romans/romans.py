from decimal import Decimal, ROUND_HALF_UP
TO_ROMAN = Decimal(1000 * (5280.0 / 4854.0))

answer = (Decimal(input()) * TO_ROMAN).to_integral_value(rounding=ROUND_HALF_UP)
print(answer)


