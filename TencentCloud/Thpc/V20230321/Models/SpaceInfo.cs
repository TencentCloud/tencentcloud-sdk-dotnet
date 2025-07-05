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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SpaceInfo : AbstractModel
    {
        
        /// <summary>
        /// 工作空间ID
        /// </summary>
        [JsonProperty("SpaceId")]
        public string SpaceId{ get; set; }

        /// <summary>
        /// 工作空间类型
        /// </summary>
        [JsonProperty("SpaceFamily")]
        public string SpaceFamily{ get; set; }

        /// <summary>
        /// 工作空间规格
        /// </summary>
        [JsonProperty("SpaceType")]
        public string SpaceType{ get; set; }

        /// <summary>
        /// 工作空间名称
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }

        /// <summary>
        /// 工作空间状态。取值范围：<br><li>PENDING：表示创建中<br></li><li>LAUNCH_FAILED：表示创建失败<br></li><li>ONLINE：表示运行中<br></li><li>ARREARS：表示隔离中<br></li><li>TERMINATING：表示销毁中。<br></li>
        /// </summary>
        [JsonProperty("SpaceState")]
        public string SpaceState{ get; set; }

        /// <summary>
        /// 工作空间计费模式
        /// </summary>
        [JsonProperty("SpaceChargeType")]
        public string SpaceChargeType{ get; set; }

        /// <summary>
        /// 工作空间对应资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 自动续费标识
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 工作空间关联的工作列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 工作空间所在位置
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 工作空间的最新操作
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestOperation")]
        public string LatestOperation{ get; set; }

        /// <summary>
        /// 工作空间的最新操作状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestOperationState")]
        public string LatestOperationState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpaceId", this.SpaceId);
            this.SetParamSimple(map, prefix + "SpaceFamily", this.SpaceFamily);
            this.SetParamSimple(map, prefix + "SpaceType", this.SpaceType);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
            this.SetParamSimple(map, prefix + "SpaceState", this.SpaceState);
            this.SetParamSimple(map, prefix + "SpaceChargeType", this.SpaceChargeType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "LatestOperation", this.LatestOperation);
            this.SetParamSimple(map, prefix + "LatestOperationState", this.LatestOperationState);
        }
    }
}

