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

namespace TencentCloud.Irp.V20220805.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecItemData : AbstractModel
    {
        
        /// <summary>
        /// 推荐的内容ID
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 内容类型，同内容上报类型一致
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemType")]
        public string ItemType{ get; set; }

        /// <summary>
        /// 推荐追踪id，本次推荐内容产生的后续行为上报均要用该ItemTraceId上报。每次接口调用返回的ItemTraceId不同
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ItemTraceId")]
        public string ItemTraceId{ get; set; }

        /// <summary>
        /// 推荐预测分，分值越高被推荐的理由越充分，取值范围[0,1000000]，用于做二次排序的参考
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Score")]
        public float? Score{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ItemType", this.ItemType);
            this.SetParamSimple(map, prefix + "ItemTraceId", this.ItemTraceId);
            this.SetParamSimple(map, prefix + "Score", this.Score);
        }
    }
}

