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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStorageServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// 云存套餐ID
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// 设备TID
        /// </summary>
        [JsonProperty("Tid")]
        public string Tid{ get; set; }

        /// <summary>
        /// 订单数量,可一次性创建多个订单
        /// </summary>
        [JsonProperty("OrderCount")]
        public long? OrderCount{ get; set; }

        /// <summary>
        /// 云存服务所在的区域,如ap-guangzhou,ap-singapore
        /// </summary>
        [JsonProperty("StorageRegion")]
        public string StorageRegion{ get; set; }

        /// <summary>
        /// 视频流通道号。(对于存在多路视频流的设备，如NVR设备，与设备实际视频流通道号对应)
        /// </summary>
        [JsonProperty("ChnNum")]
        public long? ChnNum{ get; set; }

        /// <summary>
        /// 设备主人用户在IoT Video平台的注册ID。该参数用于验证Paas/Saas平台的设备/用户关系链是否一致
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// 服务生效时间,若不指定此参数，服务立即生效
        /// </summary>
        [JsonProperty("EnableTime")]
        public long? EnableTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "Tid", this.Tid);
            this.SetParamSimple(map, prefix + "OrderCount", this.OrderCount);
            this.SetParamSimple(map, prefix + "StorageRegion", this.StorageRegion);
            this.SetParamSimple(map, prefix + "ChnNum", this.ChnNum);
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamSimple(map, prefix + "EnableTime", this.EnableTime);
        }
    }
}

