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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckAssetItem : AbstractModel
    {
        
        /// <summary>
        /// 检查项下资产组ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 资产组实例id
        /// </summary>
        [JsonProperty("Instid")]
        public string Instid{ get; set; }

        /// <summary>
        /// 处置跳转URL
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 检查任务id
        /// </summary>
        [JsonProperty("Taskid")]
        public string Taskid{ get; set; }

        /// <summary>
        /// 检查结果
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("Updatetime")]
        public string Updatetime{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 是否忽略
        /// </summary>
        [JsonProperty("IsIgnore")]
        public long? IsIgnore{ get; set; }

        /// <summary>
        /// 检查状态
        /// </summary>
        [JsonProperty("IsChecked")]
        public long? IsChecked{ get; set; }

        /// <summary>
        /// 资产组信息
        /// </summary>
        [JsonProperty("AssetInfo")]
        public string AssetInfo{ get; set; }

        /// <summary>
        /// 资产组ES的_id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 详情
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Instid", this.Instid);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Taskid", this.Taskid);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Updatetime", this.Updatetime);
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "IsIgnore", this.IsIgnore);
            this.SetParamSimple(map, prefix + "IsChecked", this.IsChecked);
            this.SetParamSimple(map, prefix + "AssetInfo", this.AssetInfo);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
        }
    }
}

