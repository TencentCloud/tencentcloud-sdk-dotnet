/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CameraControl : AbstractModel
    {
        
        /// <summary>
        /// 枚举值：“simple”, “down_back”, “forward_up”, “right_turn_forward”, “left_turn_forward”
        /// simple：简单运镜，此类型下可在"config"中六选一进行运镜
        /// down_back：镜头下压并后退 -> 下移拉远，此类型下config参数无需填写
        /// forward_up：镜头前进并上仰 -> 推进上移，此类型下config参数无需填写
        /// right_turn_forward：先右旋转后前进 -> 右旋推进，此类型下config参数无需填写
        /// left_turn_forward：先左旋并前进 -> 左旋推进，此类型下config参数无需填写
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 包含六个字段，用于指定摄像机在不同方向上的运动或变化。
        /// - 当运镜类型指定simple时必填，指定其他类型时不填
        /// - 参数6选1，即只能有一个参数不为0，其余参数为0
        /// </summary>
        [JsonProperty("Config")]
        public CameraControlConfig Config{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "Config.", this.Config);
        }
    }
}

