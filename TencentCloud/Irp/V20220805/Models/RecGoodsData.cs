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

namespace TencentCloud.Irp.V20220805.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecGoodsData : AbstractModel
    {
        
        /// <summary>
        /// 推荐返回的商品ID
        /// </summary>
        [JsonProperty("GoodsId")]
        public string GoodsId{ get; set; }

        /// <summary>
        /// 推荐结果分，取值范围[0,1000000]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }

        /// <summary>
        /// 推荐追踪id，本次推荐内容产生的后续行为上报均要用该GoodsTraceId上报。每次接口调用返回的GoodsTraceId不同
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GoodsTraceId")]
        public string GoodsTraceId{ get; set; }

        /// <summary>
        /// 商品所在位置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Position")]
        public long? Position{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GoodsId", this.GoodsId);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "GoodsTraceId", this.GoodsTraceId);
            this.SetParamSimple(map, prefix + "Position", this.Position);
        }
    }
}

