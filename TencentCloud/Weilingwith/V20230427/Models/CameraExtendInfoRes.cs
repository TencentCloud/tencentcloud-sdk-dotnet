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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CameraExtendInfoRes : AbstractModel
    {
        
        /// <summary>
        /// 存储方式 (nvr或cosmtav)
        /// </summary>
        [JsonProperty("SaveType")]
        public string SaveType{ get; set; }

        /// <summary>
        /// 云存储天数（save_type是cosmtav时这个参数才有效）
        /// </summary>
        [JsonProperty("SaveDay")]
        public long? SaveDay{ get; set; }

        /// <summary>
        /// 实时分辨率
        /// </summary>
        [JsonProperty("LiveResolution")]
        public long? LiveResolution{ get; set; }

        /// <summary>
        /// 历史分辨率
        /// </summary>
        [JsonProperty("HistoryResolution")]
        public long? HistoryResolution{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SaveType", this.SaveType);
            this.SetParamSimple(map, prefix + "SaveDay", this.SaveDay);
            this.SetParamSimple(map, prefix + "LiveResolution", this.LiveResolution);
            this.SetParamSimple(map, prefix + "HistoryResolution", this.HistoryResolution);
        }
    }
}

