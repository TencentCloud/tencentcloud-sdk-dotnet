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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyEventConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 接收事件通知的方式。
        /// <li>PUSH：[HTTP 回调通知](https://cloud.tencent.com/document/product/266/33779)；</li>
        /// <li>PULL：[基于消息队列的可靠通知](https://cloud.tencent.com/document/product/266/33779)。</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 采用 [HTTP 回调通知](https://cloud.tencent.com/document/product/266/33779) 接收方式时，用于接收 3.0 格式回调的地址。
        /// 注意：如果带 NotificationUrl  参数且值为空字符串时将会清空 3.0 格式回调地址。
        /// </summary>
        [JsonProperty("NotificationUrl")]
        public string NotificationUrl{ get; set; }

        /// <summary>
        /// 是否接收 [视频上传完成](https://cloud.tencent.com/document/product/266/7830) 事件通知， 默认 "OFF" 为忽略该事件通知，"ON" 为接收事件通知。
        /// </summary>
        [JsonProperty("UploadMediaCompleteEventSwitch")]
        public string UploadMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// 是否接收 [视频删除完成](https://cloud.tencent.com/document/product/266/13434) 事件通知，  默认 "OFF" 为忽略该事件通知，"ON" 为接收事件通知。
        /// </summary>
        [JsonProperty("DeleteMediaCompleteEventSwitch")]
        public string DeleteMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// 是否接收剪辑固化完成事件通知，  默认 "OFF" 为忽略该事件通知，"ON" 为接收事件通知。
        /// </summary>
        [JsonProperty("PersistenceCompleteEventSwitch")]
        public string PersistenceCompleteEventSwitch{ get; set; }

        /// <summary>
        /// <b>点播[应用](/document/product/266/14574) ID。从2023年12月25日起开通点播的客户，如访问点播应用中的资源（无论是默认应用还是新创建的应用），必须将该字段填写为应用 ID。</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "NotificationUrl", this.NotificationUrl);
            this.SetParamSimple(map, prefix + "UploadMediaCompleteEventSwitch", this.UploadMediaCompleteEventSwitch);
            this.SetParamSimple(map, prefix + "DeleteMediaCompleteEventSwitch", this.DeleteMediaCompleteEventSwitch);
            this.SetParamSimple(map, prefix + "PersistenceCompleteEventSwitch", this.PersistenceCompleteEventSwitch);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
        }
    }
}

