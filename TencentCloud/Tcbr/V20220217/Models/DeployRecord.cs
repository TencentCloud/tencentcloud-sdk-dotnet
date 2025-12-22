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

namespace TencentCloud.Tcbr.V20220217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployRecord : AbstractModel
    {
        
        /// <summary>
        /// 部署Id
        /// </summary>
        [JsonProperty("DeployId")]
        public string DeployId{ get; set; }

        /// <summary>
        /// 部署开始时间
        /// </summary>
        [JsonProperty("DeployTime")]
        public string DeployTime{ get; set; }

        /// <summary>
        /// 状态：running/deploying/deploy_failed
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 部署运行Id 用户查询部署日志
        /// </summary>
        [JsonProperty("RunId")]
        public string RunId{ get; set; }

        /// <summary>
        /// 构建Id
        /// </summary>
        [JsonProperty("BuildId")]
        public long? BuildId{ get; set; }

        /// <summary>
        /// 流量比例
        /// </summary>
        [JsonProperty("FlowRatio")]
        public long? FlowRatio{ get; set; }

        /// <summary>
        /// 镜像url
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 缩容状态 缩容为 zero 否则为空
        /// </summary>
        [JsonProperty("ScaleStatus")]
        public string ScaleStatus{ get; set; }

        /// <summary>
        /// 是否分配流量
        /// </summary>
        [JsonProperty("HasTraffic")]
        public bool? HasTraffic{ get; set; }

        /// <summary>
        /// 流量分配方式, FLOW: 百分比分配; URL_PARAMS: 匹配 query 参数; HEADERS: 匹配请求 Header
        /// </summary>
        [JsonProperty("TrafficType")]
        public string TrafficType{ get; set; }

        /// <summary>
        /// 当前版本是否在发布中
        /// </summary>
        [JsonProperty("IsReleasing")]
        public bool? IsReleasing{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployId", this.DeployId);
            this.SetParamSimple(map, prefix + "DeployTime", this.DeployTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RunId", this.RunId);
            this.SetParamSimple(map, prefix + "BuildId", this.BuildId);
            this.SetParamSimple(map, prefix + "FlowRatio", this.FlowRatio);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ScaleStatus", this.ScaleStatus);
            this.SetParamSimple(map, prefix + "HasTraffic", this.HasTraffic);
            this.SetParamSimple(map, prefix + "TrafficType", this.TrafficType);
            this.SetParamSimple(map, prefix + "IsReleasing", this.IsReleasing);
        }
    }
}

