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

namespace TencentCloud.Zj.V20190121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddSmsTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 商户证书
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// 短信签名，创建签名时返回
        /// </summary>
        [JsonProperty("SignID")]
        public ulong? SignID{ get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 短信内容，动态内容使用占位符{1}，{2}等表示
        /// </summary>
        [JsonProperty("TemplateContent")]
        public string TemplateContent{ get; set; }

        /// <summary>
        /// 短信类型：{0:普通短信，1:营销短信}
        /// </summary>
        [JsonProperty("SmsType")]
        public ulong? SmsType{ get; set; }

        /// <summary>
        /// 是否国际/港澳台短信：
        /// 0：表示国内短信。
        /// 1：表示国际/港澳台短信。
        /// </summary>
        [JsonProperty("International")]
        public ulong? International{ get; set; }

        /// <summary>
        /// 短信模板标签
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 发送短信活动时配置的落地链接地址,仅用作短信活动
        /// </summary>
        [JsonProperty("Urls")]
        public string[] Urls{ get; set; }

        /// <summary>
        /// 发送短信活动时用于展示人群包动态参数模板占位符序号或接口发送时变量占位符序号
        /// </summary>
        [JsonProperty("CommonParams")]
        public long?[] CommonParams{ get; set; }

        /// <summary>
        /// 发送短信活动时用于展示短连接模板占位符序号,仅用作短信活动
        /// </summary>
        [JsonProperty("UrlParams")]
        public long?[] UrlParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "SignID", this.SignID);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "TemplateContent", this.TemplateContent);
            this.SetParamSimple(map, prefix + "SmsType", this.SmsType);
            this.SetParamSimple(map, prefix + "International", this.International);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArraySimple(map, prefix + "Urls.", this.Urls);
            this.SetParamArraySimple(map, prefix + "CommonParams.", this.CommonParams);
            this.SetParamArraySimple(map, prefix + "UrlParams.", this.UrlParams);
        }
    }
}

