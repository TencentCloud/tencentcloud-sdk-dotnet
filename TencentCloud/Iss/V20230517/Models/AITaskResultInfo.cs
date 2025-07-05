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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AITaskResultInfo : AbstractModel
    {
        
        /// <summary>
        /// 人体识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Body")]
        public BodyAIResultInfo[] Body{ get; set; }

        /// <summary>
        /// 宠物识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pet")]
        public PetAIResultInfo[] Pet{ get; set; }

        /// <summary>
        /// 车辆车牌识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Car")]
        public CarAIResultInfo[] Car{ get; set; }

        /// <summary>
        /// 厨师帽结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChefHat")]
        public ChefHatAIResultInfo[] ChefHat{ get; set; }

        /// <summary>
        /// 厨师服结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChefCloth")]
        public ChefClothAIResultInfo[] ChefCloth{ get; set; }

        /// <summary>
        /// 口罩识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FaceMask")]
        public FaceMaskAIResultInfo[] FaceMask{ get; set; }

        /// <summary>
        /// 抽烟检测结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Smoking")]
        public SmokingAIResultInfo[] Smoking{ get; set; }

        /// <summary>
        /// 接打电话识别结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PhoneCall")]
        public PhoneCallAIResultInfo[] PhoneCall{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Body.", this.Body);
            this.SetParamArrayObj(map, prefix + "Pet.", this.Pet);
            this.SetParamArrayObj(map, prefix + "Car.", this.Car);
            this.SetParamArrayObj(map, prefix + "ChefHat.", this.ChefHat);
            this.SetParamArrayObj(map, prefix + "ChefCloth.", this.ChefCloth);
            this.SetParamArrayObj(map, prefix + "FaceMask.", this.FaceMask);
            this.SetParamArrayObj(map, prefix + "Smoking.", this.Smoking);
            this.SetParamArrayObj(map, prefix + "PhoneCall.", this.PhoneCall);
        }
    }
}

