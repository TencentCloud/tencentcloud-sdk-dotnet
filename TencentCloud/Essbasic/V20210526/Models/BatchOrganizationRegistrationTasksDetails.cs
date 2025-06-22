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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchOrganizationRegistrationTasksDetails : AbstractModel
    {
        
        /// <summary>
        /// 生成注册链接的任务Id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 批量创建企业任务的状态
        /// <ul>
        /// <li>Processing</li>
        /// <li>Create</li>
        /// <li>Submit</li>
        /// <li>Authorization</li>
        /// <li>Failed</li>
        /// </ul>
        /// 
        /// 各个状态所代表的含义如下表格所示：
        /// <table>
        /// <thead align="center" valign="center">
        /// <tr><th>任务状态名称</th><th>任务状态详情</th></tr>
        /// </thead>
        /// <tbody>
        /// <tr><th align="center" valign="center">Processing</th><th>企业认证任务处理中，用户调用了<a href="https://qian.tencent.com/developers/partnerApis/accounts/CreateBatchOrganizationRegistrationTasks">CreateBatchOrganizationRegistrationTasks</a>接口，但是任务还在处理中的状态</th></tr>
        /// <tr><th align="center" valign="center">Create</th><th>创建企业认证链接任务完成，可以调用生成任务链接接口</th></tr>
        /// <tr><th align="center" valign="center">Submit</th><th>企业认证任务已提交,到如下界面之后，会变为这个状态
        /// 
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/acbcec8c7a71de14d9c041e3b8ca8b3f.png)</th></tr>
        /// <tr><th align="center" valign="center">Authorization</th><th>企业认证任务认证成功,点击下图下一步，进入到授权书上传或者法人认证，则会变为这个状态
        /// 
        /// ![image](https://qcloudimg.tencent-cloud.cn/raw/c52448354871cffa729da8db4e3a6f18.png)</th></tr>
        /// <tr><th align="center" valign="center">Failed</th><th>企业认证任务失败</th></tr>
        /// </tbody>
        /// </table>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 如果任务失败,会返回错误信息
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
        }
    }
}

