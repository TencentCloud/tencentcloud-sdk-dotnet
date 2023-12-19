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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Invocation : AbstractModel
    {
        
        /// <summary>
        /// 执行活动ID。
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// 命令ID。
        /// </summary>
        [JsonProperty("CommandId")]
        public string CommandId{ get; set; }

        /// <summary>
        /// 执行任务状态。取值范围：
        /// 
        /// <ul> <li>PENDING：等待下发</li> <li>RUNNING：命令运行中</li> <li>SUCCESS：命令成功</li> <li>FAILED：命令失败</li> <li>TIMEOUT：命令超时</li> <li>PARTIAL_FAILED：命令部分失败</li> </ul>
        /// </summary>
        [JsonProperty("InvocationStatus")]
        public string InvocationStatus{ get; set; }

        /// <summary>
        /// 执行任务信息列表。
        /// </summary>
        [JsonProperty("InvocationTaskBasicInfoSet")]
        public InvocationTaskBasicInfo[] InvocationTaskBasicInfoSet{ get; set; }

        /// <summary>
        /// 执行活动描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 执行活动开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 执行活动结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 执行活动创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 执行活动更新时间。
        /// </summary>
        [JsonProperty("UpdatedTime")]
        public string UpdatedTime{ get; set; }

        /// <summary>
        /// 自定义参数取值。
        /// </summary>
        [JsonProperty("Parameters")]
        public string Parameters{ get; set; }

        /// <summary>
        /// 自定义参数的默认取值。
        /// </summary>
        [JsonProperty("DefaultParameters")]
        public string DefaultParameters{ get; set; }

        /// <summary>
        /// 执行命令的实例类型，取值范围：CVM、LIGHTHOUSE。
        /// </summary>
        [JsonProperty("InstanceKind")]
        public string InstanceKind{ get; set; }

        /// <summary>
        /// 在实例上执行命令时使用的用户名。
        /// </summary>
        [JsonProperty("Username")]
        public string Username{ get; set; }

        /// <summary>
        /// 调用来源。
        /// </summary>
        [JsonProperty("InvocationSource")]
        public string InvocationSource{ get; set; }

        /// <summary>
        /// base64编码的命令内容
        /// </summary>
        [JsonProperty("CommandContent")]
        public string CommandContent{ get; set; }

        /// <summary>
        /// 命令类型
        /// </summary>
        [JsonProperty("CommandType")]
        public string CommandType{ get; set; }

        /// <summary>
        /// 执行命令过期时间， 单位秒
        /// </summary>
        [JsonProperty("Timeout")]
        public ulong? Timeout{ get; set; }

        /// <summary>
        /// 执行命令的工作路径
        /// </summary>
        [JsonProperty("WorkingDirectory")]
        public string WorkingDirectory{ get; set; }

        /// <summary>
        /// 日志上传的cos bucket 地址。
        /// </summary>
        [JsonProperty("OutputCOSBucketUrl")]
        public string OutputCOSBucketUrl{ get; set; }

        /// <summary>
        /// 日志在cos bucket中的目录。
        /// </summary>
        [JsonProperty("OutputCOSKeyPrefix")]
        public string OutputCOSKeyPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamSimple(map, prefix + "CommandId", this.CommandId);
            this.SetParamSimple(map, prefix + "InvocationStatus", this.InvocationStatus);
            this.SetParamArrayObj(map, prefix + "InvocationTaskBasicInfoSet.", this.InvocationTaskBasicInfoSet);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "UpdatedTime", this.UpdatedTime);
            this.SetParamSimple(map, prefix + "Parameters", this.Parameters);
            this.SetParamSimple(map, prefix + "DefaultParameters", this.DefaultParameters);
            this.SetParamSimple(map, prefix + "InstanceKind", this.InstanceKind);
            this.SetParamSimple(map, prefix + "Username", this.Username);
            this.SetParamSimple(map, prefix + "InvocationSource", this.InvocationSource);
            this.SetParamSimple(map, prefix + "CommandContent", this.CommandContent);
            this.SetParamSimple(map, prefix + "CommandType", this.CommandType);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "WorkingDirectory", this.WorkingDirectory);
            this.SetParamSimple(map, prefix + "OutputCOSBucketUrl", this.OutputCOSBucketUrl);
            this.SetParamSimple(map, prefix + "OutputCOSKeyPrefix", this.OutputCOSKeyPrefix);
        }
    }
}

