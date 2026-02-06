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

namespace TencentCloud.Thpc.V20220401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueueConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>队列名称。</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>队列中弹性节点数量最小值。取值范围0～200。</p>
        /// </summary>
        [JsonProperty("MinSize")]
        public ulong? MinSize{ get; set; }

        /// <summary>
        /// <p>队列中弹性节点数量最大值。取值范围0～200。</p>
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }

        /// <summary>
        /// <p>是否开启自动扩容。</p>
        /// </summary>
        [JsonProperty("EnableAutoExpansion")]
        public bool? EnableAutoExpansion{ get; set; }

        /// <summary>
        /// <p>是否开启自动缩容。</p>
        /// </summary>
        [JsonProperty("EnableAutoShrink")]
        public bool? EnableAutoShrink{ get; set; }

        /// <summary>
        /// <p>指定有效的<a href="https://cloud.tencent.com/document/product/213/4940">镜像</a>ID，格式形如<code>img-xxx</code>。目前仅支持公有镜和特定自定义镜像。</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>节点系统盘配置信息。若不指定该参数，则按照系统默认值进行分配。</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public SystemDisk SystemDisk{ get; set; }

        /// <summary>
        /// <p>节点数据盘配置信息。若不指定该参数，则默认不购买数据盘。支持购买的时候指定21块数据盘，其中最多包含1块LOCAL_BASIC数据盘或者LOCAL_SSD数据盘，最多包含20块CLOUD_BASIC数据盘、CLOUD_PREMIUM数据盘或者CLOUD_SSD数据盘。</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>公网带宽相关信息设置。若不指定该参数，则默认公网带宽为0Mbps。</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>扩容节点配置信息。</p>
        /// </summary>
        [JsonProperty("ExpansionNodeConfigs")]
        public ExpansionNodeConfig[] ExpansionNodeConfigs{ get; set; }

        /// <summary>
        /// <p>扩容实例模板，可以在cvm侧进行设置</p>
        /// </summary>
        [JsonProperty("LaunchTemplateIds")]
        public string[] LaunchTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "EnableAutoExpansion", this.EnableAutoExpansion);
            this.SetParamSimple(map, prefix + "EnableAutoShrink", this.EnableAutoShrink);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamArrayObj(map, prefix + "ExpansionNodeConfigs.", this.ExpansionNodeConfigs);
            this.SetParamArraySimple(map, prefix + "LaunchTemplateIds.", this.LaunchTemplateIds);
        }
    }
}

