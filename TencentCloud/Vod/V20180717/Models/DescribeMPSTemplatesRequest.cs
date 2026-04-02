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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMPSTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// MPS 模板类型。根据需要查询的 MPS 模板的类型对结果进行过滤。取值：
        /// <li>Transcode: 查询转码模板列表。</li>
        /// <li>AIAnalysis: 创建智能分析模板。</li>
        /// <li>SmartSubtitle: 创建智能字幕模板。</li>
        /// <li>SmartErase: 创建智能擦除模板。</li>
        /// </summary>
        [JsonProperty("TemplateType")]
        public string TemplateType{ get; set; }

        /// <summary>
        /// MPS 查询模板参数。该参数用于透传至媒体处理服务（MPS），从云点播侧查询 MPS 任务模板列表。目前仅支持通过此方式查询以下任务类型的模板：
        /// 1. 音视频增强：仅支持填写“[获取转码模板列表](https://cloud.tencent.com/document/product/862/37593)”接口中的 Definitions、Type、Name、Offset 和 Limit 几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。
        /// 2. 智能分析：仅支持填写“[获取智能分析模板列表](https://cloud.tencent.com/document/product/862/40247)”接口中的 Definitions、Type、Name、Offset 和 Limit 几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。
        /// 3. 智能字幕：仅支持填写“[获取智能字幕模板列表](https://cloud.tencent.com/document/product/862/117002)”接口中的 Definitions、Type、Name、Offset 和 Limit 几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。
        /// 4. 智能擦除：仅支持填写“[获取智能擦除模板列表](https://cloud.tencent.com/document/product/862/123733)”接口中的 Definitions、Type、Name、Offset 和 Limit 几个参数的内容。目前仅支持在模板中配置以上参数，其他参数无需填写，若包含其它参数，系统将自动忽略。
        /// </summary>
        [JsonProperty("MPSDescribeTemplateParams")]
        public string MPSDescribeTemplateParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "TemplateType", this.TemplateType);
            this.SetParamSimple(map, prefix + "MPSDescribeTemplateParams", this.MPSDescribeTemplateParams);
        }
    }
}

