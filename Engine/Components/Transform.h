#pragma once

#include "ComponentsCommon.h"

namespace pasic::transform {

	DEFINE_TYPED_ID(transform_id);

	transform_id create_transform(const init_info& info, game_entity::entity_id entity_id);
}