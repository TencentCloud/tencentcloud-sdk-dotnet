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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VertexInfo : AbstractModel
    {
        
        /// <summary>
        /// 该结点类型，进程:1；网络:2；文件:3；ssh:4；
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 该节点包含的vid
        /// </summary>
        [JsonProperty("Vid")]
        public string Vid{ get; set; }

        /// <summary>
        /// 该节点的父节点vid
        /// </summary>
        [JsonProperty("ParentVid")]
        public string ParentVid{ get; set; }

        /// <summary>
        /// 是否叶子
        /// </summary>
        [JsonProperty("IsLeaf")]
        public bool? IsLeaf{ get; set; }

        /// <summary>
        /// 进程名，当Type=1时使用
        /// </summary>
        [JsonProperty("ProcNamePrefix")]
        public string ProcNamePrefix{ get; set; }

        /// <summary>
        /// 进程名md5，当Type=1时使用
        /// </summary>
        [JsonProperty("ProcNameMd5")]
        public string ProcNameMd5{ get; set; }

        /// <summary>
        /// 命令行，当Type=1时使用
        /// </summary>
        [JsonProperty("CmdLinePrefix")]
        public string CmdLinePrefix{ get; set; }

        /// <summary>
        /// 命令行md5，当Type=1时使用
        /// </summary>
        [JsonProperty("CmdLineMd5")]
        public string CmdLineMd5{ get; set; }

        /// <summary>
        /// 文件路径，当Type=3时使用
        /// </summary>
        [JsonProperty("FilePathPrefix")]
        public string FilePathPrefix{ get; set; }

        /// <summary>
        /// 请求目的地址，当Type=2时使用
        /// </summary>
        [JsonProperty("AddressPrefix")]
        public string AddressPrefix{ get; set; }

        /// <summary>
        /// 是否漏洞节点
        /// </summary>
        [JsonProperty("IsWeDetect")]
        public bool? IsWeDetect{ get; set; }

        /// <summary>
        /// 是否告警节点
        /// </summary>
        [JsonProperty("IsAlarm")]
        public bool? IsAlarm{ get; set; }

        /// <summary>
        /// 文件路径md5，当Type=3时使用
        /// </summary>
        [JsonProperty("FilePathMd5")]
        public string FilePathMd5{ get; set; }

        /// <summary>
        /// 请求目的地址md5，当Type=2时使用
        /// </summary>
        [JsonProperty("AddressMd5")]
        public string AddressMd5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Vid", this.Vid);
            this.SetParamSimple(map, prefix + "ParentVid", this.ParentVid);
            this.SetParamSimple(map, prefix + "IsLeaf", this.IsLeaf);
            this.SetParamSimple(map, prefix + "ProcNamePrefix", this.ProcNamePrefix);
            this.SetParamSimple(map, prefix + "ProcNameMd5", this.ProcNameMd5);
            this.SetParamSimple(map, prefix + "CmdLinePrefix", this.CmdLinePrefix);
            this.SetParamSimple(map, prefix + "CmdLineMd5", this.CmdLineMd5);
            this.SetParamSimple(map, prefix + "FilePathPrefix", this.FilePathPrefix);
            this.SetParamSimple(map, prefix + "AddressPrefix", this.AddressPrefix);
            this.SetParamSimple(map, prefix + "IsWeDetect", this.IsWeDetect);
            this.SetParamSimple(map, prefix + "IsAlarm", this.IsAlarm);
            this.SetParamSimple(map, prefix + "FilePathMd5", this.FilePathMd5);
            this.SetParamSimple(map, prefix + "AddressMd5", this.AddressMd5);
        }
    }
}

