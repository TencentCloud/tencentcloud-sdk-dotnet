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

namespace TencentCloud.Weilingwith.V20230427.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiInfo : AbstractModel
    {
        
        /// <summary>
        /// API的id
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// API名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// API所属应用的id
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// API所属的项目空间的id
        /// </summary>
        [JsonProperty("WorkspaceId")]
        public string WorkspaceId{ get; set; }

        /// <summary>
        /// API所属目录的编码
        /// </summary>
        [JsonProperty("PoiCode")]
        public string PoiCode{ get; set; }

        /// <summary>
        ///  接口分类0. 其他服务 1. IOT服务 2. 空间服务 3.微应用服务 4.场景服务 5.AI算法服务 6.任务算法服务 7.第三方服务
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 数据授权 0:否 1:是
        /// </summary>
        [JsonProperty("DataAudit")]
        public ulong? DataAudit{ get; set; }

        /// <summary>
        /// 是否需要申请 0:否 1:是
        /// </summary>
        [JsonProperty("ApplyAudit")]
        public ulong? ApplyAudit{ get; set; }

        /// <summary>
        /// API详情
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// API地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 请求方法类型
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// API状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// API预览地址
        /// </summary>
        [JsonProperty("PreviewUrl")]
        public string PreviewUrl{ get; set; }

        /// <summary>
        /// query参数
        /// </summary>
        [JsonProperty("QueryParams")]
        public ApiContent[] QueryParams{ get; set; }

        /// <summary>
        /// 路径参数
        /// </summary>
        [JsonProperty("PathParams")]
        public ApiContent[] PathParams{ get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        [JsonProperty("RequestHeaders")]
        public ApiContent[] RequestHeaders{ get; set; }

        /// <summary>
        /// 响应头
        /// </summary>
        [JsonProperty("ResponseHeaders")]
        public ApiContent[] ResponseHeaders{ get; set; }

        /// <summary>
        /// 是否为公共空间接口
        /// </summary>
        [JsonProperty("IsCommonSpace")]
        public bool? IsCommonSpace{ get; set; }

        /// <summary>
        /// 请求体（base64编码）
        /// </summary>
        [JsonProperty("Body")]
        public string Body{ get; set; }

        /// <summary>
        /// 响应体（base64编码）
        /// </summary>
        [JsonProperty("ResponseBody")]
        public string ResponseBody{ get; set; }

        /// <summary>
        /// 接口方式 1.http 2消息通知服务
        /// </summary>
        [JsonProperty("Style")]
        public ulong? Style{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "WorkspaceId", this.WorkspaceId);
            this.SetParamSimple(map, prefix + "PoiCode", this.PoiCode);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "DataAudit", this.DataAudit);
            this.SetParamSimple(map, prefix + "ApplyAudit", this.ApplyAudit);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PreviewUrl", this.PreviewUrl);
            this.SetParamArrayObj(map, prefix + "QueryParams.", this.QueryParams);
            this.SetParamArrayObj(map, prefix + "PathParams.", this.PathParams);
            this.SetParamArrayObj(map, prefix + "RequestHeaders.", this.RequestHeaders);
            this.SetParamArrayObj(map, prefix + "ResponseHeaders.", this.ResponseHeaders);
            this.SetParamSimple(map, prefix + "IsCommonSpace", this.IsCommonSpace);
            this.SetParamSimple(map, prefix + "Body", this.Body);
            this.SetParamSimple(map, prefix + "ResponseBody", this.ResponseBody);
            this.SetParamSimple(map, prefix + "Style", this.Style);
        }
    }
}

