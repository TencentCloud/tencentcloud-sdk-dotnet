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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyMetricConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 指标日志主题id。
        /// - 通过 [获取日志主题列表](https://cloud.tencent.com/document/product/614/56454) 获取日志主题Id。注意BizType 0:日志主题（默认值）， 1:指标主题
        /// - 通过 [创建日志主题](https://cloud.tencent.com/document/product/614/56456) 获取日志主题Id。注意BizType 0:日志主题（默认值）， 1:指标主题
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 指标采集配置id
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 采集配置来源。支持 ：`0`、`1`
        /// - 0:自建k8s
        /// - 1:TKE
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// 机器组id。
        /// </summary>
        [JsonProperty("GroupIds")]
        public string[] GroupIds{ get; set; }

        /// <summary>
        /// 操作状态,0:应用,1:暂停
        /// </summary>
        [JsonProperty("Operate")]
        public ulong? Operate{ get; set; }

        /// <summary>
        /// 采集对象, Flag=0时生效
        /// </summary>
        [JsonProperty("Spec")]
        public MetricSpec Spec{ get; set; }

        /// <summary>
        /// 标签处理, Flag=0时生效
        /// </summary>
        [JsonProperty("MetricRelabels")]
        public Relabeling[] MetricRelabels{ get; set; }

        /// <summary>
        /// 自定义元数据, Flag=0时生效
        /// </summary>
        [JsonProperty("MetricLabel")]
        public MetricConfigLabel MetricLabel{ get; set; }

        /// <summary>
        /// 通信协议 `http`、`https`；Flag=0时生效
        /// </summary>
        [JsonProperty("Scheme")]
        public string Scheme{ get; set; }

        /// <summary>
        /// 采集频率,  Flag=0时生效
        /// - 校验格式：`^(((\d+)y)?((\d+)w)?((\d+)d)?((\d+)h)?((\d+)m)?((\d+)s)?((\d+)ms)?|0)$`
        /// - 默认：60s
        /// </summary>
        [JsonProperty("ScrapeInterval")]
        public string ScrapeInterval{ get; set; }

        /// <summary>
        /// 采集超时时间。   Flag=0时生效
        /// - 校验格式：`^(((\d+)y)?((\d+)w)?((\d+)d)?((\d+)h)?((\d+)m)?((\d+)s)?((\d+)ms)?|0)$`
        /// </summary>
        [JsonProperty("ScrapeTimeout")]
        public string ScrapeTimeout{ get; set; }

        /// <summary>
        /// Prometheus如何处理标签之间的冲突。当Flag=0 && Type=1时生效，支持`true`,`false`
        /// - `false`:配置数据中冲突的标签重命名
        /// - `true`:忽略冲突的服务器端标签
        /// </summary>
        [JsonProperty("HonorLabels")]
        public bool? HonorLabels{ get; set; }

        /// <summary>
        /// 采集配置yaml格式字符串, Flag=1时必填
        /// </summary>
        [JsonProperty("YamlSpec")]
        public MetricYamlSpec YamlSpec{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamObj(map, prefix + "Spec.", this.Spec);
            this.SetParamArrayObj(map, prefix + "MetricRelabels.", this.MetricRelabels);
            this.SetParamObj(map, prefix + "MetricLabel.", this.MetricLabel);
            this.SetParamSimple(map, prefix + "Scheme", this.Scheme);
            this.SetParamSimple(map, prefix + "ScrapeInterval", this.ScrapeInterval);
            this.SetParamSimple(map, prefix + "ScrapeTimeout", this.ScrapeTimeout);
            this.SetParamSimple(map, prefix + "HonorLabels", this.HonorLabels);
            this.SetParamObj(map, prefix + "YamlSpec.", this.YamlSpec);
        }
    }
}

