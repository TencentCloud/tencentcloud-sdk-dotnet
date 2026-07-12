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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextModerationRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>待检测的文本内容，需为UTF-8编码并以Base64格式传入。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>接口使用的识别策略编号，需在<a href="https://console.cloud.tencent.com/cms/clouds/manage">控制台</a>获取。详细获取方式请参考以下链接：</p><ul><li><strong>内容安全</strong>（详见步骤四：策略配置）：<a href="https://cloud.tencent.com/document/product/1124/37119">点击这里</a></li><li><strong>AI生成识别</strong>（详见服务对接-&gt;方式二）：<a href="https://cloud.tencent.com/document/product/1124/118694">点击这里</a></li></ul>
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>该字段表示您为待检测文本分配的数据ID，作用是方便您对数据进行标识和管理。<br>取值：可由英文字母、数字、四种特殊符号（_，-，@，#）组成，<strong>长度不超过64个字符</strong>。</p>
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// <p>该字段标识用户信息，传入后可增强甄别有违规风险的发布者账号。</p>
        /// </summary>
        [JsonProperty("User")]
        public User User{ get; set; }

        /// <summary>
        /// <p>该字段标识设备信息，传入后可增强甄别有违规风险的发布者设备。</p>
        /// </summary>
        [JsonProperty("Device")]
        public Device Device{ get; set; }

        /// <summary>
        /// <p>Content字段的原始语种，枚举值包括 zh 和 en：</p><ul><li>推荐使用 zh</li><li>en 适用于纯英文内容，耗时较高。若需使用 en，请先通过<a href="https://console.cloud.tencent.com/workorder/category?level1_id=141&amp;level2_id=1287&amp;source=14&amp;data_title=%E6%96%87%E6%9C%AC%E5%86%85%E5%AE%B9%E5%AE%89%E5%85%A8&amp;step=1">反馈工单</a>确认</li></ul>
        /// </summary>
        [JsonProperty("SourceLanguage")]
        public string SourceLanguage{ get; set; }

        /// <summary>
        /// <p>服务类型，枚举值包括 TEXT 和 TEXT_AIGC：<br>TEXT：内容安全<br>TEXT_AIGC：AI生成识别</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>适用于上下文关联审核场景，若多条文本内容需要联合审核，通过该字段关联会话。</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamObj(map, prefix + "User.", this.User);
            this.SetParamObj(map, prefix + "Device.", this.Device);
            this.SetParamSimple(map, prefix + "SourceLanguage", this.SourceLanguage);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
        }
    }
}

