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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Program : AbstractModel
    {
        
        /// <summary>
        /// 数据集ID
        /// </summary>
        [JsonProperty("ProgramId")]
        public string ProgramId{ get; set; }

        /// <summary>
        /// 数据集名称
        /// </summary>
        [JsonProperty("ProgramName")]
        public string ProgramName{ get; set; }

        /// <summary>
        /// 数据集描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProgramDesc")]
        public string ProgramDesc{ get; set; }

        /// <summary>
        /// 删除标识，true: 可以删除; false: 不可删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public long? CreationTime{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public long? LastUpdateTime{ get; set; }

        /// <summary>
        /// 数据项列表，无值时返回空数组
        /// </summary>
        [JsonProperty("ProgramItemList")]
        public ProgramItem[] ProgramItemList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProgramId", this.ProgramId);
            this.SetParamSimple(map, prefix + "ProgramName", this.ProgramName);
            this.SetParamSimple(map, prefix + "ProgramDesc", this.ProgramDesc);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamArrayObj(map, prefix + "ProgramItemList.", this.ProgramItemList);
        }
    }
}

