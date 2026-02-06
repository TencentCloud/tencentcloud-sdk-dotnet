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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QCloudYeheNoticeTmpl : AbstractModel
    {
        
        /// <summary>
        /// 邮件通知渠道
        /// </summary>
        [JsonProperty("Email")]
        public QCloudYeheNoticeTmplItem Email{ get; set; }

        /// <summary>
        /// 企业微信通知渠道
        /// </summary>
        [JsonProperty("QYWX")]
        public QCloudYeheNoticeTmplItem QYWX{ get; set; }

        /// <summary>
        /// 短信通知渠道
        /// </summary>
        [JsonProperty("SMS")]
        public QCloudYeheNoticeTmplItem SMS{ get; set; }

        /// <summary>
        /// 语音通知渠道
        /// </summary>
        [JsonProperty("Voice")]
        public QCloudYeheNoticeTmplItem Voice{ get; set; }

        /// <summary>
        /// 微信通知渠道
        /// </summary>
        [JsonProperty("WeChat")]
        public QCloudYeheWeChatNoticeTmplItem WeChat{ get; set; }

        /// <summary>
        /// 站内信通知渠道
        /// </summary>
        [JsonProperty("Site")]
        public QCloudYeheNoticeTmplItem Site{ get; set; }

        /// <summary>
        /// 安灯通知渠道
        /// </summary>
        [JsonProperty("Andon")]
        public QCloudYeheNoticeTmplItem Andon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Email.", this.Email);
            this.SetParamObj(map, prefix + "QYWX.", this.QYWX);
            this.SetParamObj(map, prefix + "SMS.", this.SMS);
            this.SetParamObj(map, prefix + "Voice.", this.Voice);
            this.SetParamObj(map, prefix + "WeChat.", this.WeChat);
            this.SetParamObj(map, prefix + "Site.", this.Site);
            this.SetParamObj(map, prefix + "Andon.", this.Andon);
        }
    }
}

