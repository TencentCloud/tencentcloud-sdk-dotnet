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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UserTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 用户账户ID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 任务状态，0-任务初始化中；1-任务运行中；2-任务成功；3-任务失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务类型，0-实例回档；1-实例创建；2-实例扩容；3-实例迁移；4-实例删除；5-实例重启
        /// </summary>
        [JsonProperty("UserTaskType")]
        public long? UserTaskType{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 任务错误信息
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 客户端参数
        /// </summary>
        [JsonProperty("InputData")]
        public string InputData{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UserTaskType", this.UserTaskType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "InputData", this.InputData);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
        }
    }
}

