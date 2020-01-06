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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ShieldInfo : AbstractModel
    {
        
        /// <summary>
        /// 加固结果的返回码
        /// </summary>
        [JsonProperty("ShieldCode")]
        public ulong? ShieldCode{ get; set; }

        /// <summary>
        /// 加固后app的大小
        /// </summary>
        [JsonProperty("ShieldSize")]
        public ulong? ShieldSize{ get; set; }

        /// <summary>
        /// 加固后app的md5
        /// </summary>
        [JsonProperty("ShieldMd5")]
        public string ShieldMd5{ get; set; }

        /// <summary>
        /// 加固后的APP下载地址，该地址有效期为20分钟，请及时下载
        /// </summary>
        [JsonProperty("AppUrl")]
        public string AppUrl{ get; set; }

        /// <summary>
        /// 加固的提交时间
        /// </summary>
        [JsonProperty("TaskTime")]
        public ulong? TaskTime{ get; set; }

        /// <summary>
        /// 任务唯一标识
        /// </summary>
        [JsonProperty("ItemId")]
        public string ItemId{ get; set; }

        /// <summary>
        /// 加固版本，basic基础版，professional专业版，enterprise企业版
        /// </summary>
        [JsonProperty("ServiceEdition")]
        public string ServiceEdition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShieldCode", this.ShieldCode);
            this.SetParamSimple(map, prefix + "ShieldSize", this.ShieldSize);
            this.SetParamSimple(map, prefix + "ShieldMd5", this.ShieldMd5);
            this.SetParamSimple(map, prefix + "AppUrl", this.AppUrl);
            this.SetParamSimple(map, prefix + "TaskTime", this.TaskTime);
            this.SetParamSimple(map, prefix + "ItemId", this.ItemId);
            this.SetParamSimple(map, prefix + "ServiceEdition", this.ServiceEdition);
        }
    }
}

