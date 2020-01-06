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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleOutInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 时间单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 时间长度
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// 扩容实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 付费类型
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// Token
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 预执行脚本设置
        /// </summary>
        [JsonProperty("PreExecutedFileSettings")]
        public PreExecuteFileSettings[] PreExecutedFileSettings{ get; set; }

        /// <summary>
        /// 扩容Task节点数量
        /// </summary>
        [JsonProperty("TaskCount")]
        public ulong? TaskCount{ get; set; }

        /// <summary>
        /// 扩容Core节点数量
        /// </summary>
        [JsonProperty("CoreCount")]
        public ulong? CoreCount{ get; set; }

        /// <summary>
        /// 扩容时不需要安装的进程
        /// </summary>
        [JsonProperty("UnNecessaryNodeList")]
        public ulong?[] UnNecessaryNodeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamArrayObj(map, prefix + "PreExecutedFileSettings.", this.PreExecutedFileSettings);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "CoreCount", this.CoreCount);
            this.SetParamArraySimple(map, prefix + "UnNecessaryNodeList.", this.UnNecessaryNodeList);
        }
    }
}

