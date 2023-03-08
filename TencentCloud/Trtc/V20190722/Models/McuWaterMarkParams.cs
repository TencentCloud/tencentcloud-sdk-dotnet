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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuWaterMarkParams : AbstractModel
    {
        
        /// <summary>
        /// 水印类型，0为图片（默认），1为文字。
        /// </summary>
        [JsonProperty("WaterMarkType")]
        public ulong? WaterMarkType{ get; set; }

        /// <summary>
        /// 图片水印参数。WaterMarkType为0指定。
        /// </summary>
        [JsonProperty("WaterMarkImage")]
        public McuWaterMarkImage WaterMarkImage{ get; set; }

        /// <summary>
        /// 文字水印参数。WaterMarkType为1指定。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WaterMarkText")]
        public McuWaterMarkText WaterMarkText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WaterMarkType", this.WaterMarkType);
            this.SetParamObj(map, prefix + "WaterMarkImage.", this.WaterMarkImage);
            this.SetParamObj(map, prefix + "WaterMarkText.", this.WaterMarkText);
        }
    }
}

