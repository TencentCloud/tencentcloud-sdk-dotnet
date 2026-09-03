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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBatchVideoAnnotationJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>批量输入源信息（目录前缀）</p>
        /// </summary>
        [JsonProperty("InputStorage")]
        public BatchS3SourceInfo InputStorage{ get; set; }

        /// <summary>
        /// <p>标注模式（当前仅开放精标注）</p><p>枚举值：</p><ul><li>3： 精标注</li></ul>
        /// </summary>
        [JsonProperty("AnnotationType")]
        public long? AnnotationType{ get; set; }

        /// <summary>
        /// <p>标注上下文信息</p>
        /// </summary>
        [JsonProperty("AnnotationContext")]
        public AnnotationContext AnnotationContext{ get; set; }

        /// <summary>
        /// <p>标注处理参数，预留字段，当前无效</p>
        /// </summary>
        [JsonProperty("ProcessParams")]
        public ProcessParams ProcessParams{ get; set; }

        /// <summary>
        /// <p>批量结果输出存储信息，不传则不投递</p>
        /// </summary>
        [JsonProperty("OutputStorage")]
        public OutputStorage OutputStorage{ get; set; }

        /// <summary>
        /// <p>回调信息，配置后当任务下子处理项状态从处理中变为其他状态时，服务端会向回调地址发送请求（退避重试三次，不保证回调一定送达，需保证目标地址接收服务有效），建议接收方做好幂等处理。回调请求格式如下：<br><strong>请求头</strong></p><table><thead><tr><th>名称</th><th>值</th></tr></thead><tbody><tr><td>X-Annotation-Signature</td><td>hex(HMAC-SHA256(请求体原始字节, CallbackInfo.Secret))</td></tr></tbody></table><p><strong>请求体</strong>（application/json）</p><table><thead><tr><th>参数名</th><th>类型</th><th>必选</th><th>描述</th></tr></thead><tbody><tr><td>JobId</td><td>string</td><td>是</td><td>任务 ID</td></tr><tr><td>TaskId</td><td>string</td><td>是</td><td>处理项 ID</td></tr><tr><td>FileName</td><td>string</td><td>是</td><td>视频文件名</td></tr><tr><td>Status</td><td>int</td><td>是</td><td>触发本次回调的处理项状态：3 超时，4 异常，5 待确认，6 成功</td></tr><tr><td>StatusChangedAt</td><td>int</td><td>是</td><td>状态变更时间，Unix 时间戳（秒）</td></tr><tr><td>RawResult</td><td>string</td><td>否</td><td>当前生效的结果 JSON 原文：成功=标注产物；待确认=原始标注；确认后=确认版内容。超时/异常无内容</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("CallbackInfo")]
        public CallbackInfo CallbackInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "InputStorage.", this.InputStorage);
            this.SetParamSimple(map, prefix + "AnnotationType", this.AnnotationType);
            this.SetParamObj(map, prefix + "AnnotationContext.", this.AnnotationContext);
            this.SetParamObj(map, prefix + "ProcessParams.", this.ProcessParams);
            this.SetParamObj(map, prefix + "OutputStorage.", this.OutputStorage);
            this.SetParamObj(map, prefix + "CallbackInfo.", this.CallbackInfo);
        }
    }
}

