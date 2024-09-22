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

    public class DescribeEventConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// 接收事件通知的方式。"PUSH" 为 [HTTP 回调通知](https://cloud.tencent.com/document/product/266/7829#http.E5.9B.9E.E8.B0.83)，"PULL" 为 [基于消息队列的可靠通知](https://cloud.tencent.com/document/product/266/7829#.E5.9F.BA.E4.BA.8E.E6.B6.88.E6.81.AF.E9.98.9F.E5.88.97.E7.9A.84.E5.8F.AF.E9.9D.A0.E9.80.9A.E7.9F.A5)。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 采用 [HTTP 回调通知](https://cloud.tencent.com/document/product/266/7829#http.E5.9B.9E.E8.B0.83) 接收方式时，用于接收 V3 版本事件通知的地址。
        /// </summary>
        [JsonProperty("NotificationUrl")]
        public string NotificationUrl{ get; set; }

        /// <summary>
        /// 是否接收 [视频上传完成](https://cloud.tencent.com/document/product/266/7830) 事件通知，"OFF" 为忽略该事件通知，"ON" 为接收事件通知。
        /// </summary>
        [JsonProperty("UploadMediaCompleteEventSwitch")]
        public string UploadMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// 是否接收 [视频删除完成](https://cloud.tencent.com/document/product/266/13434) 事件通知，"OFF" 为忽略该事件通知，"ON" 为接收事件通知。
        /// </summary>
        [JsonProperty("DeleteMediaCompleteEventSwitch")]
        public string DeleteMediaCompleteEventSwitch{ get; set; }

        /// <summary>
        /// 是否接收剪辑固化完成事件通知，"OFF" 为忽略该事件通知，"ON" 为接收事件通知。
        /// </summary>
        [JsonProperty("PersistenceCompleteEventSwitch")]
        public string PersistenceCompleteEventSwitch{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


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
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

