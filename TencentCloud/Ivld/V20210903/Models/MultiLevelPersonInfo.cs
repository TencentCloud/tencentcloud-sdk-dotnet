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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MultiLevelPersonInfo : AbstractModel
    {
        
        /// <summary>
        /// 一级分类名称(分类信息参见自定义人物类型)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("L1ClassifyName")]
        public string L1ClassifyName{ get; set; }

        /// <summary>
        /// 已分类人物信息数组(所有分类类型为二级分类)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("L2ClassifiedPersonInfoSet")]
        public ClassifiedPersonInfo[] L2ClassifiedPersonInfoSet{ get; set; }

        /// <summary>
        /// 检测结果来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "L1ClassifyName", this.L1ClassifyName);
            this.SetParamArrayObj(map, prefix + "L2ClassifiedPersonInfoSet.", this.L2ClassifiedPersonInfoSet);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}

