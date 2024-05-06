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

    public class CreateAlarmNoticeRequest : AbstractModel
    {
        
        /// <summary>
        /// 通知渠道组名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 通知类型。可选值：
        /// - Trigger - 告警触发
        /// - Recovery - 告警恢复
        /// - All - 告警触发和告警恢复
        /// 
        /// 
        ///  注意:  
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，其中Type必填，NoticeReceivers和WebCallbacks至少一个不为空，NoticeRules是另一组配置，其中rule不许为空，2组配置互斥。
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，NoticeRules是另一组配置，必须填写一组配置。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 通知接收对象。
        ///  注意:  
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，其中Type必填，NoticeReceivers和WebCallbacks至少一个不为空，NoticeRules是另一组配置，其中rule不许为空，2组配置互斥。
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，NoticeRules是另一组配置，必须填写一组配置。
        /// </summary>
        [JsonProperty("NoticeReceivers")]
        public NoticeReceiver[] NoticeReceivers{ get; set; }

        /// <summary>
        /// 接口回调信息（包括企业微信）。
        ///  注意:  
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，其中Type必填，NoticeReceivers和WebCallbacks至少一个不为空，NoticeRules是另一组配置，其中rule不许为空，2组配置互斥。
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，NoticeRules是另一组配置，必须填写一组配置。
        /// </summary>
        [JsonProperty("WebCallbacks")]
        public WebCallback[] WebCallbacks{ get; set; }

        /// <summary>
        /// 通知规则。
        ///  注意:  
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，其中Type必填，NoticeReceivers和WebCallbacks至少一个不为空，NoticeRules是另一组配置，其中rule不许为空，2组配置互斥。
        /// - Type、NoticeReceivers和WebCallbacks是一组配置，NoticeRules是另一组配置，必须填写一组配置。
        /// 
        /// </summary>
        [JsonProperty("NoticeRules")]
        public NoticeRule[] NoticeRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "NoticeReceivers.", this.NoticeReceivers);
            this.SetParamArrayObj(map, prefix + "WebCallbacks.", this.WebCallbacks);
            this.SetParamArrayObj(map, prefix + "NoticeRules.", this.NoticeRules);
        }
    }
}

