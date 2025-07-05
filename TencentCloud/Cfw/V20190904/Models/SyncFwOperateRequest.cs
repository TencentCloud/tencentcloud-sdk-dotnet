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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SyncFwOperateRequest : AbstractModel
    {
        
        /// <summary>
        /// 同步操作类型：Route，同步防火墙路由
        /// </summary>
        [JsonProperty("SyncType")]
        public string SyncType{ get; set; }

        /// <summary>
        /// 防火墙类型；nat,nat防火墙;ew,vpc间防火墙
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SyncType", this.SyncType);
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
        }
    }
}

