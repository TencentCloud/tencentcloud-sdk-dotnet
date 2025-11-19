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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAlarmNoticeRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名，这里填“monitor”
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 告警通知规则名称 60字符以内
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 通知类型 ALARM=未恢复通知 OK=已恢复通知 ALL=都通知
        /// </summary>
        [JsonProperty("NoticeType")]
        public string NoticeType{ get; set; }

        /// <summary>
        /// 通知语言 zh-CN=中文 en-US=英文
        /// </summary>
        [JsonProperty("NoticeLanguage")]
        public string NoticeLanguage{ get; set; }

        /// <summary>
        /// 告警通知模板 ID
        /// </summary>
        [JsonProperty("NoticeId")]
        public string NoticeId{ get; set; }

        /// <summary>
        /// 用户通知 最多5个
        /// </summary>
        [JsonProperty("UserNotices")]
        public UserNotice[] UserNotices{ get; set; }

        /// <summary>
        /// 回调通知 最多6个
        /// </summary>
        [JsonProperty("URLNotices")]
        public URLNotice[] URLNotices{ get; set; }

        /// <summary>
        /// 告警通知推送到CLS服务 最多1个
        /// </summary>
        [JsonProperty("CLSNotices")]
        public CLSNotice[] CLSNotices{ get; set; }

        /// <summary>
        /// 告警通知模板绑定的告警策略ID列表
        /// </summary>
        [JsonProperty("PolicyIds")]
        public string[] PolicyIds{ get; set; }

        /// <summary>
        /// 是否免登录，0-否，1-是
        /// </summary>
        [JsonProperty("IsLoginFree")]
        public long? IsLoginFree{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NoticeType", this.NoticeType);
            this.SetParamSimple(map, prefix + "NoticeLanguage", this.NoticeLanguage);
            this.SetParamSimple(map, prefix + "NoticeId", this.NoticeId);
            this.SetParamArrayObj(map, prefix + "UserNotices.", this.UserNotices);
            this.SetParamArrayObj(map, prefix + "URLNotices.", this.URLNotices);
            this.SetParamArrayObj(map, prefix + "CLSNotices.", this.CLSNotices);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "IsLoginFree", this.IsLoginFree);
        }
    }
}

