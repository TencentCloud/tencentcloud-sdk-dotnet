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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CNAPIGwConsumerGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>分组id</p>
        /// </summary>
        [JsonProperty("ConsumerGroupId")]
        public string ConsumerGroupId{ get; set; }

        /// <summary>
        /// <p>名字</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>状态Disable/Enable</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间 yyyy-MM-dd hh:mm:ss</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>绑定的消费者数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BindCount")]
        public ulong? BindCount{ get; set; }

        /// <summary>
        /// <p>同步状态</p><p>枚举值：</p><ul><li>Fail： 失败</li><li>Succes： 成功</li></ul>
        /// </summary>
        [JsonProperty("SyncStatus")]
        public string SyncStatus{ get; set; }

        /// <summary>
        /// <p>资源类型</p><p>枚举值：</p><ul><li>Public： 公共</li><li>Private： 私有</li><li>SourceDeleted： 资源已删除</li></ul>
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// <p>同步版本</p>
        /// </summary>
        [JsonProperty("SyncedVersion")]
        public string SyncedVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConsumerGroupId", this.ConsumerGroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "BindCount", this.BindCount);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SyncedVersion", this.SyncedVersion);
        }
    }
}

