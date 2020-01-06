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

    public class VerifyIdlFilesResponse : AbstractModel
    {
        
        /// <summary>
        /// 本次上传校验所有的Idl文件信息列表
        /// </summary>
        [JsonProperty("IdlFiles")]
        public IdlFileInfo[] IdlFiles{ get; set; }

        /// <summary>
        /// 读取Idl描述文件后解析出的合法表数量，不包含已经创建的表
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 读取Idl描述文件后解析出的合法表列表，不包含已经创建的表
        /// </summary>
        [JsonProperty("TableInfos")]
        public ParsedTableInfo[] TableInfos{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "IdlFiles.", this.IdlFiles);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "TableInfos.", this.TableInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

