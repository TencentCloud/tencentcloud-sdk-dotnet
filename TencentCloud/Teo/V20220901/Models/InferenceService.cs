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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceService : AbstractModel
    {
        
        /// <summary>
        /// 推理服务 ID。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 推理服务的名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 模型服务需要监听的端口。仅支持 1-65535 之间的整数。
        /// </summary>
        [JsonProperty("ListenPort")]
        public long? ListenPort{ get; set; }

        /// <summary>
        /// 推理服务的请求路径列表。最多支持 20 个路径。
        /// </summary>
        [JsonProperty("RequestPaths")]
        public string[] RequestPaths{ get; set; }

        /// <summary>
        /// 推理服务的容器配置。
        /// </summary>
        [JsonProperty("Containers")]
        public InferenceContainerConfig[] Containers{ get; set; }

        /// <summary>
        /// 推理服务的资源配置。
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public InferenceResourceConfig ResourceConfig{ get; set; }

        /// <summary>
        /// 推理服务状态，包含以下几种状态：<li>Deploying：部署中；</li><li>Running：运行中；</li><li>Stopping：停止中；</li><li>Stopped：已停止；</li><li>Exception：异常；</li><li>Banned：被封禁。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 伸缩状态。取值有：<li>Normal：稳定运行，无进行中的伸缩操作；</li><li>ScalingOut：扩容中；</li><li>ScalingIn：缩容中。</li>
        /// </summary>
        [JsonProperty("ScalingStatus")]
        public string ScalingStatus{ get; set; }

        /// <summary>
        /// 当前运行中的实例数量。
        /// </summary>
        [JsonProperty("CurrentInstanceCount")]
        public long? CurrentInstanceCount{ get; set; }

        /// <summary>
        /// 推理访问地址，可通过链接访问底层模型进行推理。
        /// </summary>
        [JsonProperty("InferenceURL")]
        public string InferenceURL{ get; set; }

        /// <summary>
        /// 创建时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后修改时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ListenPort", this.ListenPort);
            this.SetParamArraySimple(map, prefix + "RequestPaths.", this.RequestPaths);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ScalingStatus", this.ScalingStatus);
            this.SetParamSimple(map, prefix + "CurrentInstanceCount", this.CurrentInstanceCount);
            this.SetParamSimple(map, prefix + "InferenceURL", this.InferenceURL);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

