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

namespace TencentCloud.Yunjing.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddMachineTagRequest : AbstractModel
    {
        
        /// <summary>
        /// 云主机ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 标签ID
        /// </summary>
        [JsonProperty("TagId")]
        public ulong? TagId{ get; set; }

        /// <summary>
        /// 主机地区
        /// </summary>
        [JsonProperty("MRegion")]
        public string MRegion{ get; set; }

        /// <summary>
        /// 主机地区类型(CVM|BM)
        /// </summary>
        [JsonProperty("MArea")]
        public string MArea{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "TagId", this.TagId);
            this.SetParamSimple(map, prefix + "MRegion", this.MRegion);
            this.SetParamSimple(map, prefix + "MArea", this.MArea);
        }
    }
}

