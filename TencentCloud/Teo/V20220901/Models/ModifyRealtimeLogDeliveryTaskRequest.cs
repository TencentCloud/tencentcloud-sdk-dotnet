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

    public class ModifyRealtimeLogDeliveryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务 ID。</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务的名称，格式为数字、英文、-和_组合，最多 200 个字符。不填保持原有配置。</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务的状态，取值有：</p><li>enabled: 启用；</li><li>disabled: 停用。</li>不填保持原有配置。
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public string DeliveryStatus{ get; set; }

        /// <summary>
        /// <p>实时日志投递任务对应的实体（七层域名或者四层代理实例）列表。取值示例如下：</p><li>七层域名：domain.example.com；</li><li>四层代理实例：sid-2s69eb5wcms7。</li>不填保持原有配置。<p>取值参考：<a href="https://cloud.tencent.com/document/api/1552/80690">DescribeApplicationProxies</a></p>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// <p>投递的预设字段列表。不填保持原有配置。</p><p>取值参考：DescribeLogFields</p>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// <p>投递的自定义日志字段列表，可以通过自定义日志推送字段名称和取值表达式，实现个性化的实时日志内容推送，详见 <a href="">自定义日志字段表达式</a>。<br>仅七层访问日志（LogType= l7-access-logs 或 domain）支持添加自定义字段，允许配置的自定义字段个数有配额限制，如遇配额不足请 <a href="https://cloud.tencent.com/online-service?from=sales&amp;source=PRESALE">联系我们</a> 。</p>
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// <p>投递的自定义表达式字段列表，可以通过自定义日志推送字段名称和取值表达式，实现个性化的实时日志内容推送，使用详情见 [自定义日志字段表达式]()。<br>仅七层访问日志（LogType= l7-access-logs 或 domain）支持添加自定义字段。允许配置的自定义字段个数有配额限制，如遇配额不足请 [联系我们](https://cloud.tencent.com/online-service?from=sales&amp;source=PRESALE) 。<br>**注意**：若 CustomExpressionFields 中存在命名 与 Fields 和 CustomFields 中同名的字段，以  CustomExpressionFields 中的取值为准。</p>
        /// </summary>
        [JsonProperty("CustomExpressionFields")]
        public CustomExpressionField[] CustomExpressionFields{ get; set; }

        /// <summary>
        /// <p>日志投递的过滤条件。不填表示投递全量日志。</p>
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// <p>采样比例，采用千分制，取值范围为1-1000，例如：填写 605 表示采样比例为 60.5%。不填保持原有配置。</p>
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// <p>日志投递的输出格式，使用详情见 <a href="https://cloud.tencent.com/document/product/1552/110448">自定义日志输出格式</a>。不填表示为默认格式，默认格式逻辑如下：<ul><li>当 TaskType 取值为 custom_endpoint 时，默认格式为多个 JSON 对象组成的数组，每个 JSON 对象为一条日志；</li><li>当 TaskType 取值为 s3 时，默认格式为 JSON Lines；</li></ul>特别地，当 TaskType 取值为 cls 或 log_analysis 时，LogFormat.FormatType 的值只能为 json，且 LogFormat 中其他参数将被忽略，建议不传 LogFormat。</p>
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// <p>自定义 HTTP 服务的配置信息，不填保持原有配置。</p>
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// <p>AWS S3 兼容存储桶的配置信息，不填保持原有配置。</p>
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DeliveryStatus", this.DeliveryStatus);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "CustomExpressionFields.", this.CustomExpressionFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
        }
    }
}

