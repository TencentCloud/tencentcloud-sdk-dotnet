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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TerminateWorkspacesRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间ID
        /// </summary>
        [JsonProperty("SpaceIds")]
        public string[] SpaceIds{ get; set; }

        /// <summary>
        /// 释放空间挂载的包年包月数据盘。true表示销毁空间同时释放包年包月数据盘，false表示只销毁空间。
        /// </summary>
        [JsonProperty("ReleasePrepaidDataDisks")]
        public bool? ReleasePrepaidDataDisks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SpaceIds.", this.SpaceIds);
            this.SetParamSimple(map, prefix + "ReleasePrepaidDataDisks", this.ReleasePrepaidDataDisks);
        }
    }
}

