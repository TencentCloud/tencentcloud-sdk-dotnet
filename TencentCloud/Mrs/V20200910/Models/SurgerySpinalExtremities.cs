/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SurgerySpinalExtremities : AbstractModel
    {
        
        /// <summary>
        /// 脊柱四肢总体描述
        /// </summary>
        [JsonProperty("Text")]
        public KeyValueItem Text{ get; set; }

        /// <summary>
        /// 脊柱
        /// </summary>
        [JsonProperty("SpinalColumn")]
        public KeyValueItem SpinalColumn{ get; set; }

        /// <summary>
        /// 四肢和关节
        /// </summary>
        [JsonProperty("LimbJoint")]
        public KeyValueItem LimbJoint{ get; set; }

        /// <summary>
        /// 平跛足
        /// </summary>
        [JsonProperty("Foot")]
        public KeyValueItem Foot{ get; set; }

        /// <summary>
        /// 骨骼
        /// </summary>
        [JsonProperty("Bone")]
        public KeyValueItem Bone{ get; set; }

        /// <summary>
        /// 步态
        /// </summary>
        [JsonProperty("Gait")]
        public KeyValueItem Gait{ get; set; }

        /// <summary>
        /// 残疾或畸形
        /// </summary>
        [JsonProperty("Deformity")]
        public KeyValueItem Deformity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "SpinalColumn.", this.SpinalColumn);
            this.SetParamObj(map, prefix + "LimbJoint.", this.LimbJoint);
            this.SetParamObj(map, prefix + "Foot.", this.Foot);
            this.SetParamObj(map, prefix + "Bone.", this.Bone);
            this.SetParamObj(map, prefix + "Gait.", this.Gait);
            this.SetParamObj(map, prefix + "Deformity.", this.Deformity);
        }
    }
}

