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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PsaRegulation : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("PsaId")]
        public string PsaId{ get; set; }

        /// <summary>
        /// 规则别名
        /// </summary>
        [JsonProperty("PsaName")]
        public string PsaName{ get; set; }

        /// <summary>
        /// 关联标签数量
        /// </summary>
        [JsonProperty("TagCount")]
        public ulong? TagCount{ get; set; }

        /// <summary>
        /// 关联实例数量
        /// </summary>
        [JsonProperty("InstanceCount")]
        public ulong? InstanceCount{ get; set; }

        /// <summary>
        /// 故障实例数量
        /// </summary>
        [JsonProperty("RepairCount")]
        public ulong? RepairCount{ get; set; }

        /// <summary>
        /// 故障实例上限
        /// </summary>
        [JsonProperty("RepairLimit")]
        public ulong? RepairLimit{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 规则备注
        /// </summary>
        [JsonProperty("PsaDescription")]
        public string PsaDescription{ get; set; }

        /// <summary>
        /// 关联标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 关联故障类型id
        /// </summary>
        [JsonProperty("TaskTypeIds")]
        public ulong?[] TaskTypeIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PsaId", this.PsaId);
            this.SetParamSimple(map, prefix + "PsaName", this.PsaName);
            this.SetParamSimple(map, prefix + "TagCount", this.TagCount);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "RepairCount", this.RepairCount);
            this.SetParamSimple(map, prefix + "RepairLimit", this.RepairLimit);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PsaDescription", this.PsaDescription);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "TaskTypeIds.", this.TaskTypeIds);
        }
    }
}

