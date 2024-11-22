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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyCasterRequest : AbstractModel
    {
        
        /// <summary>
        /// 源导播台的ID
        /// </summary>
        [JsonProperty("CasterId")]
        public ulong? CasterId{ get; set; }

        /// <summary>
        /// 复制产生的新导播台名称
        /// </summary>
        [JsonProperty("CasterName")]
        public string CasterName{ get; set; }

        /// <summary>
        /// 复制产生的导播台推送到云直播的流id
        /// 注意：该流id不能与云直播中的流id重复
        /// </summary>
        [JsonProperty("OutputStreamId")]
        public string OutputStreamId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasterId", this.CasterId);
            this.SetParamSimple(map, prefix + "CasterName", this.CasterName);
            this.SetParamSimple(map, prefix + "OutputStreamId", this.OutputStreamId);
        }
    }
}

