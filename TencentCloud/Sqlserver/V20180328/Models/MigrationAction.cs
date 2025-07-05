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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrationAction : AbstractModel
    {
        
        /// <summary>
        /// 支持的所有操作，值包括：view(查看任务) ，modify(修改任务)， start(启动任务)，incremental(创建增量任务)，delete(删除任务)，upload(获取上传权限)。
        /// </summary>
        [JsonProperty("AllAction")]
        public string[] AllAction{ get; set; }

        /// <summary>
        /// 当前状态允许的操作，AllAction的子集,为空表示禁止所有操作
        /// </summary>
        [JsonProperty("AllowedAction")]
        public string[] AllowedAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AllAction.", this.AllAction);
            this.SetParamArraySimple(map, prefix + "AllowedAction.", this.AllowedAction);
        }
    }
}

