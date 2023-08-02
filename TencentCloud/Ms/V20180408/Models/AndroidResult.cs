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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AndroidResult : AbstractModel
    {
        
        /// <summary>
        /// 结果Id,用于查询加固结果
        /// </summary>
        [JsonProperty("ResultId")]
        public string ResultId{ get; set; }

        /// <summary>
        /// 与当前任务关联的订单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 与当前任务关联的资源Id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 本次任务发起者
        /// </summary>
        [JsonProperty("OpUin")]
        public long? OpUin{ get; set; }

        /// <summary>
        /// 应用类型：android-apk; android-aab;
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 应用包名
        /// </summary>
        [JsonProperty("AppPkgName")]
        public string AppPkgName{ get; set; }

        /// <summary>
        /// 后台资源绑定的包名
        /// </summary>
        [JsonProperty("BindAppPkgName")]
        public string BindAppPkgName{ get; set; }

        /// <summary>
        /// 加固结果
        /// </summary>
        [JsonProperty("EncryptState")]
        public long? EncryptState{ get; set; }

        /// <summary>
        /// 加固结果描述
        /// </summary>
        [JsonProperty("EncryptStateDesc")]
        public string EncryptStateDesc{ get; set; }

        /// <summary>
        /// 加固失败错误码
        /// </summary>
        [JsonProperty("EncryptErrCode")]
        public long? EncryptErrCode{ get; set; }

        /// <summary>
        /// 加固失败原因
        /// </summary>
        [JsonProperty("EncryptErrDesc")]
        public string EncryptErrDesc{ get; set; }

        /// <summary>
        /// 加固失败解决方案
        /// </summary>
        [JsonProperty("EncryptErrRef")]
        public string EncryptErrRef{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("CreatTime")]
        public string CreatTime{ get; set; }

        /// <summary>
        /// 任务开始处理时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 任务处理结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 加固耗时（秒单位）
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// 在线加固-android应用原包下载链接
        /// </summary>
        [JsonProperty("AppUrl")]
        public string AppUrl{ get; set; }

        /// <summary>
        /// 在线加固-android应用文件MD5算法值
        /// </summary>
        [JsonProperty("AppMd5")]
        public string AppMd5{ get; set; }

        /// <summary>
        /// 在线加固-android应用应用名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 在线加固-android应用版本；
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// 在线加固-android应用大小
        /// </summary>
        [JsonProperty("AppSize")]
        public long? AppSize{ get; set; }

        /// <summary>
        /// 在线加固-android加固-腾讯云应用加固工具版本
        /// </summary>
        [JsonProperty("OnlineToolVersion")]
        public string OnlineToolVersion{ get; set; }

        /// <summary>
        /// 在线加固-android加固，加固成功后文件md5算法值
        /// </summary>
        [JsonProperty("EncryptAppMd5")]
        public string EncryptAppMd5{ get; set; }

        /// <summary>
        /// 在线加固-android加固，加固成功后应用大小
        /// </summary>
        [JsonProperty("EncryptAppSize")]
        public long? EncryptAppSize{ get; set; }

        /// <summary>
        /// 在线加固-android加固，加固包下载链接。
        /// </summary>
        [JsonProperty("EncryptPkgUrl")]
        public string EncryptPkgUrl{ get; set; }

        /// <summary>
        /// 输出工具-android加固-腾讯云输出工具版本
        /// </summary>
        [JsonProperty("OutputToolVersion")]
        public string OutputToolVersion{ get; set; }

        /// <summary>
        /// 输出工具-android加固-工具大小
        /// </summary>
        [JsonProperty("OutputToolSize")]
        public long? OutputToolSize{ get; set; }

        /// <summary>
        /// 输出工具-android加固-工具输出时间
        /// </summary>
        [JsonProperty("ToolOutputTime")]
        public string ToolOutputTime{ get; set; }

        /// <summary>
        /// 输出工具-android加固-工具到期时间
        /// </summary>
        [JsonProperty("ToolExpireTime")]
        public string ToolExpireTime{ get; set; }

        /// <summary>
        /// 输出工具-android加固-输出工具下载链接
        /// </summary>
        [JsonProperty("OutputToolUrl")]
        public string OutputToolUrl{ get; set; }

        /// <summary>
        /// 本次android加固策略信息
        /// </summary>
        [JsonProperty("AndroidPlan")]
        public AndroidPlan AndroidPlan{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResultId", this.ResultId);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "OpUin", this.OpUin);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamSimple(map, prefix + "AppPkgName", this.AppPkgName);
            this.SetParamSimple(map, prefix + "BindAppPkgName", this.BindAppPkgName);
            this.SetParamSimple(map, prefix + "EncryptState", this.EncryptState);
            this.SetParamSimple(map, prefix + "EncryptStateDesc", this.EncryptStateDesc);
            this.SetParamSimple(map, prefix + "EncryptErrCode", this.EncryptErrCode);
            this.SetParamSimple(map, prefix + "EncryptErrDesc", this.EncryptErrDesc);
            this.SetParamSimple(map, prefix + "EncryptErrRef", this.EncryptErrRef);
            this.SetParamSimple(map, prefix + "CreatTime", this.CreatTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "AppUrl", this.AppUrl);
            this.SetParamSimple(map, prefix + "AppMd5", this.AppMd5);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "AppSize", this.AppSize);
            this.SetParamSimple(map, prefix + "OnlineToolVersion", this.OnlineToolVersion);
            this.SetParamSimple(map, prefix + "EncryptAppMd5", this.EncryptAppMd5);
            this.SetParamSimple(map, prefix + "EncryptAppSize", this.EncryptAppSize);
            this.SetParamSimple(map, prefix + "EncryptPkgUrl", this.EncryptPkgUrl);
            this.SetParamSimple(map, prefix + "OutputToolVersion", this.OutputToolVersion);
            this.SetParamSimple(map, prefix + "OutputToolSize", this.OutputToolSize);
            this.SetParamSimple(map, prefix + "ToolOutputTime", this.ToolOutputTime);
            this.SetParamSimple(map, prefix + "ToolExpireTime", this.ToolExpireTime);
            this.SetParamSimple(map, prefix + "OutputToolUrl", this.OutputToolUrl);
            this.SetParamObj(map, prefix + "AndroidPlan.", this.AndroidPlan);
        }
    }
}

