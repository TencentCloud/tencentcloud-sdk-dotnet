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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KBSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>关联的应用列表，仅共享知识库返回</p>
        /// </summary>
        [JsonProperty("AppList")]
        public Identity[] AppList{ get; set; }

        /// <summary>
        /// <p>创建时间（Unix 秒）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public Operator Creator{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>文档数</p>
        /// </summary>
        [JsonProperty("DocCount")]
        public ulong? DocCount{ get; set; }

        /// <summary>
        /// <p>是否超量</p>
        /// </summary>
        [JsonProperty("IsExceeded")]
        public bool? IsExceeded{ get; set; }

        /// <summary>
        /// <p>知识库 ID</p>
        /// </summary>
        [JsonProperty("KbId")]
        public string KbId{ get; set; }

        /// <summary>
        /// <p>类型：1=默认知识库，2=共享知识库<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>KB_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>KB_TYPE_DEFAULT</td><td>1</td><td>默认知识库</td></tr><tr><td>KB_TYPE_SHARED</td><td>2</td><td>共享知识库</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("KbType")]
        public long? KbType{ get; set; }

        /// <summary>
        /// <p>最后操作人，仅共享知识库返回</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestOperator")]
        public Operator LatestOperator{ get; set; }

        /// <summary>
        /// <p>知识库名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>处理中状态列表</p>
        /// </summary>
        [JsonProperty("ProcessingFlagList")]
        public long?[] ProcessingFlagList{ get; set; }

        /// <summary>
        /// <p>共享子类型：1=普通，2=公众号<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>SHARED_KB_SUB_TYPE_UNKNOWN</td><td>0</td><td></td></tr><tr><td>SHARED_KB_SUB_TYPE_NORMAL</td><td>1</td><td>普通</td></tr><tr><td>SHARED_KB_SUB_TYPE_PUBLIC_ACCOUNT</td><td>2</td><td>公众号</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("SharedSubType")]
        public long? SharedSubType{ get; set; }

        /// <summary>
        /// <p>更新时间（Unix 秒）</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "AppList.", this.AppList);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "Creator.", this.Creator);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DocCount", this.DocCount);
            this.SetParamSimple(map, prefix + "IsExceeded", this.IsExceeded);
            this.SetParamSimple(map, prefix + "KbId", this.KbId);
            this.SetParamSimple(map, prefix + "KbType", this.KbType);
            this.SetParamObj(map, prefix + "LatestOperator.", this.LatestOperator);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "ProcessingFlagList.", this.ProcessingFlagList);
            this.SetParamSimple(map, prefix + "SharedSubType", this.SharedSubType);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

