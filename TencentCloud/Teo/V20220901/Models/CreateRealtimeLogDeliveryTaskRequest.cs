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

    public class CreateRealtimeLogDeliveryTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点 ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 实时日志投递任务的名称，格式为数字、英文、-和_组合，最多 200 个字符。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 实时日志投递任务类型，取值有：
        /// <li>cls: 推送到腾讯云 CLS；</li>
        /// <li>custom_endpoint：推送到自定义 HTTP(S) 地址；</li>
        /// <li>s3：推送到 AWS S3 兼容存储桶地址；</li>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// 实时日志投递任务对应的实体列表。取值示例如下：
        /// <li>七层域名：domain.example.com</li>
        /// <li>四层代理实例：sid-2s69eb5wcms7</li>
        /// <li>边缘函数实例：test-zone-2mxigizoh9l9-1257626257</li>
        /// </summary>
        [JsonProperty("EntityList")]
        public string[] EntityList{ get; set; }

        /// <summary>
        /// 数据投递类型，取值有：
        /// <li>domain：站点加速日志；</li>
        /// <li>application：四层代理日志；</li>
        /// <li>function：边缘函数运行日志；</li>
        /// <li>web-rateLiming：速率限制和 CC 攻击防护日志；</li>
        /// <li>web-attack：托管规则日志；</li>
        /// <li>web-rule：自定义规则日志；</li>
        /// <li>web-bot：Bot管理日志。</li>
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 数据投递区域，取值有：
        /// <li>mainland：中国大陆境内；</li>
        /// <li>overseas：全球（不含中国大陆）。</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 投递的预设字段列表。取值参考：
        /// <li>[站点加速日志（七层访问日志）](https://cloud.tencent.com/document/product/1552/105791)</li>
        /// <li>[四层代理日志](https://cloud.tencent.com/document/product/1552/105792)</li>
        /// <li>[边缘函数运行日志](https://cloud.tencent.com/document/product/1552/115585)</li>
        /// </summary>
        [JsonProperty("Fields")]
        public string[] Fields{ get; set; }

        /// <summary>
        /// 投递的自定义字段列表，支持在 HTTP 请求头、响应头、Cookie、请求正文中提取指定内容。自定义字段名称不能重复，且最多不能超过 200 个字段。单个实时日志推送任务最多添加 5 个请求正文类型的自定义字段。目前仅站点加速日志（LogType=domain）支持添加自定义字段。
        /// </summary>
        [JsonProperty("CustomFields")]
        public CustomField[] CustomFields{ get; set; }

        /// <summary>
        /// 日志投递的过滤条件，不填表示投递全量日志。
        /// </summary>
        [JsonProperty("DeliveryConditions")]
        public DeliveryCondition[] DeliveryConditions{ get; set; }

        /// <summary>
        /// 采样比例，采用千分制，取值范围为1-1000，例如：填写 605 表示采样比例为 60.5%。不填表示采样比例为 100%。
        /// </summary>
        [JsonProperty("Sample")]
        public ulong? Sample{ get; set; }

        /// <summary>
        /// 日志投递的输出格式。不填表示为默认格式，默认格式逻辑如下：
        /// <li>当 TaskType 取值为 custom_endpoint 时，默认格式为多个 JSON 对象组成的数组，每个 JSON 对象为一条日志；</li>
        /// <li>当 TaskType 取值为 s3 时，默认格式为 JSON Lines；</li>特别地，当 TaskType 取值为 cls 时，LogFormat.FormatType 的值只能为 json，且 LogFormat 中其他参数将被忽略，建议不传 LogFormat。
        /// </summary>
        [JsonProperty("LogFormat")]
        public LogFormat LogFormat{ get; set; }

        /// <summary>
        /// CLS 的配置信息。当 TaskType 取值为 cls 时，该参数必填。
        /// </summary>
        [JsonProperty("CLS")]
        public CLSTopic CLS{ get; set; }

        /// <summary>
        /// 自定义 HTTP 服务的配置信息。当 TaskType 取值为 custom_endpoint 时，该参数必填。
        /// </summary>
        [JsonProperty("CustomEndpoint")]
        public CustomEndpoint CustomEndpoint{ get; set; }

        /// <summary>
        /// AWS S3 兼容存储桶的配置信息。当 TaskType 取值为 s3 时，该参数必填。
        /// </summary>
        [JsonProperty("S3")]
        public S3 S3{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "EntityList.", this.EntityList);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamArraySimple(map, prefix + "Fields.", this.Fields);
            this.SetParamArrayObj(map, prefix + "CustomFields.", this.CustomFields);
            this.SetParamArrayObj(map, prefix + "DeliveryConditions.", this.DeliveryConditions);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamObj(map, prefix + "LogFormat.", this.LogFormat);
            this.SetParamObj(map, prefix + "CLS.", this.CLS);
            this.SetParamObj(map, prefix + "CustomEndpoint.", this.CustomEndpoint);
            this.SetParamObj(map, prefix + "S3.", this.S3);
        }
    }
}

