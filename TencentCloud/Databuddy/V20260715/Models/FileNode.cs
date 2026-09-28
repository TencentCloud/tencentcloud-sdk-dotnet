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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileNode : AbstractModel
    {
        
        /// <summary>
        /// <p>当前节点</p>
        /// </summary>
        [JsonProperty("Node")]
        public FileMeta Node{ get; set; }

        /// <summary>
        /// <p>父节点</p>
        /// </summary>
        [JsonProperty("Parent")]
        public FileMeta Parent{ get; set; }

        /// <summary>
        /// <p>创建人</p>
        /// </summary>
        [JsonProperty("Creator")]
        public UserInfo Creator{ get; set; }

        /// <summary>
        /// <p>拥有者</p>
        /// </summary>
        [JsonProperty("Owner")]
        public UserInfo Owner{ get; set; }

        /// <summary>
        /// <p>节点类型</p>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>原始路径</p>
        /// </summary>
        [JsonProperty("OriginPath")]
        public string OriginPath{ get; set; }

        /// <summary>
        /// <p>回收时间</p>
        /// </summary>
        [JsonProperty("DeleteTime")]
        public string DeleteTime{ get; set; }

        /// <summary>
        /// <p>文件git配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GitConfig")]
        public GitRepoConfig GitConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Node.", this.Node);
            this.SetParamObj(map, prefix + "Parent.", this.Parent);
            this.SetParamObj(map, prefix + "Creator.", this.Creator);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "OriginPath", this.OriginPath);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamObj(map, prefix + "GitConfig.", this.GitConfig);
        }
    }
}

