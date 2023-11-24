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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScheduledSqlResouceInfo : AbstractModel
    {
        
        /// <summary>
        /// 目标主题id
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 主题的地域信息
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 主题类型：0为日志主题，1为指标主题
        /// </summary>
        [JsonProperty("BizType")]
        public long? BizType{ get; set; }

        /// <summary>
        /// 指标名称
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 指标名称
        /// BizType为1时，优先使用MetricNames字段信息。多指标只能填充到MetricNames字段，单指标建议填充到MetricNames字段
        /// </summary>
        [JsonProperty("MetricNames")]
        public string[] MetricNames{ get; set; }

        /// <summary>
        /// 指标项
        /// </summary>
        [JsonProperty("MetricLabels")]
        public string[] MetricLabels{ get; set; }

        /// <summary>
        /// 自定义时间
        /// </summary>
        [JsonProperty("CustomTime")]
        public string CustomTime{ get; set; }

        /// <summary>
        /// 自定义标签
        /// </summary>
        [JsonProperty("CustomMetricLabels")]
        public MetricLabel[] CustomMetricLabels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamArraySimple(map, prefix + "MetricNames.", this.MetricNames);
            this.SetParamArraySimple(map, prefix + "MetricLabels.", this.MetricLabels);
            this.SetParamSimple(map, prefix + "CustomTime", this.CustomTime);
            this.SetParamArrayObj(map, prefix + "CustomMetricLabels.", this.CustomMetricLabels);
        }
    }
}

