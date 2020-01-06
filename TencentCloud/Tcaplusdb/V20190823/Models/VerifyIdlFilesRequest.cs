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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VerifyIdlFilesRequest : AbstractModel
    {
        
        /// <summary>
        /// 待加表的应用实例ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 待加表的大区ID
        /// </summary>
        [JsonProperty("LogicZoneId")]
        public string LogicZoneId{ get; set; }

        /// <summary>
        /// 曾经上传过的IDL文件信息列表，与NewIdlFiles至少有一者
        /// </summary>
        [JsonProperty("ExistingIdlFiles")]
        public IdlFileInfo[] ExistingIdlFiles{ get; set; }

        /// <summary>
        /// 待上传的IDL文件信息列表，与ExistingIdlFiles至少有一者
        /// </summary>
        [JsonProperty("NewIdlFiles")]
        public IdlFileInfo[] NewIdlFiles{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "LogicZoneId", this.LogicZoneId);
            this.SetParamArrayObj(map, prefix + "ExistingIdlFiles.", this.ExistingIdlFiles);
            this.SetParamArrayObj(map, prefix + "NewIdlFiles.", this.NewIdlFiles);
        }
    }
}

