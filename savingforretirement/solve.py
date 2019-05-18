bob_age, bob_retire, bob_saving, alice_age, alice_saving = [int(x) for x in input().split()]

bob_total = (bob_retire - bob_age) * bob_saving

alice_years_needed = bob_total // alice_saving
# make sure we go over bobs total unless we match exactly
if alice_years_needed * alice_saving <= bob_total:
    alice_years_needed += 1

print(alice_years_needed + alice_age)
