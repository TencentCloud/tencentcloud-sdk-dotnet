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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CarPlateContent : AbstractModel
    {
        
        /// <summary>
        /// 车牌信息。
        /// </summary>
        [JsonProperty("Plate")]
        public string Plate{ get; set; }

        /// <summary>
        /// 车牌颜色。
        /// </summary>
        [JsonProperty("Color")]
        public string Color{ get; set; }

        /// <summary>
        /// 车牌类型，包含：0普通蓝牌，1双层黄牌，2单层黄牌，3新能源车牌，4使馆车牌，5领馆车牌，6澳门车牌，7香港车牌，8警用车牌，9教练车牌，10武警车牌，11军用车牌   -2遮挡污损模糊车牌/异常   其他无牌
        /// 注意：
        /// 此字段可能返回 null，表示取不到有效值。
        /// 此字段结果遮挡污损模糊车牌/异常：包含PlateStatus参数的“遮挡污损模糊车牌”，针对车牌异常，建议参考此字段，更全面
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 车牌在图片中的坐标信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlateLocation")]
        public Coord[] PlateLocation{ get; set; }

        /// <summary>
        /// 判断车牌是否遮挡：“遮挡污损模糊车牌”和"正常车牌"。
        /// </summary>
        [JsonProperty("PlateStatus")]
        public string PlateStatus{ get; set; }

        /// <summary>
        /// 车牌遮挡的置信度，0-100。
        /// </summary>
        [JsonProperty("PlateStatusConfidence")]
        public long? PlateStatusConfidence{ get; set; }

        /// <summary>
        /// 车牌角度。
        /// </summary>
        [JsonProperty("PlateAngle")]
        public float? PlateAngle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Plate", this.Plate);
            this.SetParamSimple(map, prefix + "Color", this.Color);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "PlateLocation.", this.PlateLocation);
            this.SetParamSimple(map, prefix + "PlateStatus", this.PlateStatus);
            this.SetParamSimple(map, prefix + "PlateStatusConfidence", this.PlateStatusConfidence);
            this.SetParamSimple(map, prefix + "PlateAngle", this.PlateAngle);
        }
    }
}

